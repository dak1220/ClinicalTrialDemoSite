# Clinical Trial Demo Site

### Overview:
ASP.NET MVC site that displays clinical trial information to the user and allows them to search and send trials they are interested in to their email.

___

### Read Me:
This app was built on Visual Studio 2019 targeting .NET Core 3.1.

#### Settings Tab
The Settings tab must be initialized with data in order for emails to work. A SendGrid API Key as well as 
Dynamic Email Template Id must be provided. The Dynamic Template Id from SendGrid must contain the following 
custom fields and types:

+ { StudyDescription } -> Text
+ { StudyName } -> Text
+ { StudyRank } -> Number

The Settings tab also allows for specifying the sending email address.

#### Emails Tab
The Emails tab shows a list of emails that have sent since the site was first used.

#### Home Tab
The Home tab allows for the user to specify a condition and click `Search`.
The result set will be displayed in the table below and allow the user to navigate through the list using
`Previous` and `Next`. Once the user finds studies they want more information about, they can check one
or many checkboxes next to the various studies, enter their email address in the textbox below and click
`Email` to have the requests sent to their mailbox.
