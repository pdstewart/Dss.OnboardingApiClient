# Dss.OnboardingApiClient

## Description

Dss.OnboardingApiClient is a simple .NET API client implementation wrapping much of the functionality exposed by the [321Forms (Dynamic Screening Solutions) employee onboarding REST API](https://api.321forms.com/docs/version/1/).

###Getting Started
	// create the client 
	var client = new OnboardingApiClient(@"https://api.321forms.com/v1",  // the API URL you'd like to use
										 999,                             // your 321Forms Company ID
										 "username",                      // the 321Forms user account you use for API access - create a dedicated HR Admin account
										 "your_secret_key");              // your API secret key - find this on the "Edit Account" page for your API user

	// retrieve a list of the divisions in your company
	var divisions = client.GetDivisions();

	// retrieve the 25 most recent hires for a division
	var recentHires = client.GetCompletedUsers(divisions[0].ID);
