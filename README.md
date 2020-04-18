# Introduction 
Create an asp.net  core 3.1 mvc project which does the following (****Note this is not asp.net  core razor pages. It uses razor in the .cshtml pages but it is mvc. They have simlarties but we don't use razor pages):

/////base requirements

Use Visual Studio Community Edition to create a project .net core 3.1 mvc project. (To see your final I am going to open the solution in visual studio and see how much of it is running and this is the fully featured free version)
Use Code first for the database with Entity Framework for ORM
The site will require local logins stored in the DB. There should be a register page to register an account to be able to sign in.
The home page should be accessible to anyone, no login required.
Authenticated users should be able to enter book names and the date they ready them.
Authenticated users should be able to view a list of all users along with the books associated to each user.
/////Go for the gold

Add another project to the solution that is a .net core mvc API which authenticates the users.
Call the API from the main project to verify credentials (Due to time contstraints I wouldn't expect a token exchange for identities just a simple repsone the main site recieves so it knows if the credentials were valid.)
You can image this service/API running and handling mutliple services from a site and other websites. I am looking for the concept and framework.
Design and navigation is important so please take a bit of time thinking about this. The more items of the above I can see the better. Please have the proper .gitignore for visual studio so all the hidden files and preferences are not checked in.

When you check in your final version please let me know so I can review and set up a call to discuss.