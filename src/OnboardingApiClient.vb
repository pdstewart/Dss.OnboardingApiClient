Imports ServiceStack.Text
Imports ServiceStack.ServiceClient.Web

Public Class OnboardingApiClient

    Shared Sub New()
        'implement a custom date type so we can fix the timezone during deserialization
        ServiceStack.Text.JsConfig(Of DssDate).DeSerializeFn = Function(t)
                                                                   Dim result = ServiceStack.Text.JsonSerializer.DeserializeFromString(Of Date?)(t)

                                                                   If result.HasValue Then
                                                                       result = result.Value.AddHours(-7)
                                                                       Return New DssDate(result.Value.ToUniversalTime())
                                                                   End If

                                                                   Return New DssDate()
                                                               End Function
    End Sub

    Public Sub New(endpointUrl As String, companyID As Integer, username As String, secretKey As String)
        _EndpointUrl = endpointUrl
        _CompanyID = companyID
        _Username = username
        _SecretKey = secretKey
    End Sub

    Public Property EndpointUrl As String

    Public Property CompanyID As Integer

    Public Property Username As String

    Public Property SecretKey As String

    ''' <summary>
    ''' Gets a list of the divisions for the current company
    ''' </summary>
    ''' <returns></returns>
    Public Function GetDivisions() As List(Of Division)
        Dim request As New GetCompanyDivisions() With {.CompanyID = CompanyID}
        Dim header = GetRequestHeaderFor(request)

        Using c = New JsonServiceClient(EndpointUrl)
            header.AddTo(c.Headers)

            Dim result = c.Get(request)

            Return result.Divisions

        End Using
    End Function

    ''' <summary>
    ''' Gets a list of all available forms for the company
    ''' </summary>
    ''' <returns></returns>
    Public Function GetForms() As List(Of CompanyForm)
        Dim request As New GetCompanyForms() With {.CompanyID = CompanyID}
        Dim header = GetRequestHeaderFor(request)

        Using c = New JsonServiceClient(EndpointUrl)
            header.AddTo(c.Headers)

            Dim result = c.Get(request)

            Return result

        End Using
    End Function

    ''' <summary>
    ''' Returns the full deatil of the specified form including questions
    ''' </summary>
    ''' <param name="formID"></param>
    ''' <returns></returns>
    Public Function GetFormDetail(formID As Integer) As CompanyFormDetail
        Dim request As New GetCompanyFormDetail() With {.CompanyID = CompanyID, .FormID = formID}
        Dim header = GetRequestHeaderFor(request)

        Using c = New JsonServiceClient(EndpointUrl)
            header.AddTo(c.Headers)

            Dim result = c.Get(request)

            Return result

        End Using

    End Function

    ''' <summary>
    ''' Returns a list of metadata for the forms submitted by the user
    ''' </summary>
    ''' <param name="username"></param>
    ''' <returns></returns>
    Public Function GetSubmittedForms(username As String) As List(Of AssignedForm)
        Dim request As New GetUserSubmittedForms() With {.Username = username}
        Dim header = GetRequestHeaderFor(request)

        Using c = New JsonServiceClient(EndpointUrl)
            header.AddTo(c.Headers)

            Dim result = c.Get(request)

            Return result

        End Using
    End Function

    ''' <summary>
    ''' Returns a list of all uploaded file metadata for the specified user
    ''' </summary>
    ''' <param name="username"></param>
    ''' <returns></returns>
    Public Function GetUploadedFiles(username As String) As List(Of UploadedFileMetadata)
        Dim request As New GetUserUploadedFiles() With {.Username = username}
        Dim header = GetRequestHeaderFor(request)

        Using c = New JsonServiceClient(EndpointUrl)
            header.AddTo(c.Headers)

            Dim result = c.Get(request)

            Return result

        End Using
    End Function

    ''' <summary>
    ''' Returns the metadata and file bytes for the specified uploaded file in the user's account
    ''' </summary>
    ''' <param name="username"></param>
    ''' <param name="fileID"></param>
    ''' <returns></returns>
    Public Function GetUploadedFile(username As String, fileID As Integer) As UploadedFile
        Dim request As New GetUserUploadedFile() With {.Username = username, .FileID = fileID}
        Dim header = GetRequestHeaderFor(request)

        Using c = New JsonServiceClient(EndpointUrl)
            header.AddTo(c.Headers)

            Dim result = c.Get(request)

            Return result

        End Using
    End Function

    ''' <summary>
    ''' Returns the metatdata and PDF file bytes for the specified approved form
    ''' </summary>
    ''' <param name="username"></param>
    ''' <param name="formID"></param>
    ''' <returns></returns>
    Public Function GetSubmittedFormPdf(username As String, formID As Integer) As SubmittedFormPdf
        Dim request As New GetUserSubmittedFormPdf() With {.Username = username, .FormID = formID}
        Dim header = GetRequestHeaderFor(request)

        Using c = New JsonServiceClient(EndpointUrl)
            header.AddTo(c.Headers)

            Dim result = c.Get(request)

            Return result

        End Using
    End Function

    ''' <summary>
    ''' Returns the metadata and question responses for the specified approved form
    ''' </summary>
    ''' <param name="username"></param>
    ''' <param name="formID"></param>
    ''' <returns></returns>
    Public Function GetSubmittedFormResponses(username As String, formID As Integer) As SubmittedFormResponses
        Dim request As New GetUserSubmittedFormResponses() With {.Username = username, .FormID = formID}
        Dim header = GetRequestHeaderFor(request)

        Using c = New JsonServiceClient(EndpointUrl)
            header.AddTo(c.Headers)

            Dim result = c.Get(request)

            Return result

        End Using
    End Function

    ''' <summary>
    ''' Gets the last 25 users who completed onboarding
    ''' </summary>
    ''' <param name="divisionID"></param>
    ''' <returns></returns>
    Public Function GetCompletedUsers(divisionID As Integer) As List(Of CompletedUser)
        Dim request As New FindCompletedUsers(divisionID)
        Dim header = GetRequestHeaderFor(request)

        Using c = New JsonServiceClient(EndpointUrl)
            header.AddTo(c.Headers)

            Return c.Get(request)
        End Using

    End Function

    ''' <summary>
    ''' Gets a 321Forms User by Username
    ''' </summary>
    ''' <param name="username"></param>
    ''' <returns></returns>
    Public Function GetUser(username As String) As User
        Dim userRequest = New GetUser() With {.Username = username}
        Dim header = GetRequestHeaderFor(userRequest)

        Using c = New JsonServiceClient(EndpointUrl)
            header.AddTo(c.Headers)

            Return c.Get(userRequest)
        End Using

    End Function

    ''' <summary>
    ''' Deactivates the 321Forms user account of the specified user
    ''' </summary>
    ''' <param name="username"></param>
    Public Sub DeactivateUser(username As String)
        Dim deactivateRequest = New DeactivateUser() With {.Username = username}
        Dim header = GetRequestHeaderFor(deactivateRequest)

        Using c = New JsonServiceClient(EndpointUrl)
            header.AddTo(c.Headers)

            c.Put(deactivateRequest)
        End Using

    End Sub

    ''' <summary>
    ''' Returns the Relative SSO URI for the provided unique ID
    ''' </summary>
    ''' <param name="uid">User's Unique ID</param>
    ''' <returns>
    ''' Relative SSO Redirect URI.  
    ''' This is the RELATIVE URI ONLY...you should combine this value with your preferred root path e.g. https://www.321Forms.com
    ''' </returns>
    ''' <remarks>
    ''' If the user is establishing a new SSO connection you should assign them a new GUID and provide that value.
    ''' If the user has previously established an SSO connection you should provide their existing Unique ID.
    ''' </remarks>
    Public Function GetSsoUri(uid As Guid) As Uri
        Dim ssoRequest = New GetSsoUri() With {.Uid = uid}
        Dim header = GetRequestHeaderFor(ssoRequest)

        Using c = New JsonServiceClient(EndpointUrl)
            header.AddTo(c.Headers)

            Dim response = c.Post(ssoRequest)

            Return New Uri(response.RelativePath, UriKind.Relative)
        End Using

    End Function

    Private Function GetRequestHeaderFor(request As Object) As RequestHeader
        Dim result As New RequestHeader()

        'get the verb used for the request
        Dim attributes = request.GetType.GetCustomAttributes(GetType(ServiceStack.ServiceHost.RouteAttribute),
                                                             True).Cast(Of ServiceStack.ServiceHost.RouteAttribute)()
        If attributes.Any() Then
            result.Action = attributes(0).Verbs
        End If

        result.Username = Username
        result.Authorization = Helper.GetBase64EncodedHmacSha1(result.ToJson(), SecretKey)

        Return result
    End Function

End Class
