

https://stackoverflow.com/questions/74707520/multi-tenancy-in-net-6-using-keycloak-without-restarting-net-application


Here’s the Plan:
===============

Store Tenant Info Somewhere Dynamic Instead of putting all your tenant info (like issuer and audience) in appsettings.json, store it in a database or some other place that can be updated while the app is running. This way, when a new tenant is added, you don’t need to restart the app

Figure Out Which Tenant is Making the Request When a request comes in, figure out which tenant it belongs to. You can do this by:

Checking a custom header (e.g., X-Tenant-Id)

Looking at the domain they’re using

Or even grabbing the tenant ID from a claim inside the JWT token

Validate the Token Dynamically Use something called JwtBearerEvents to customize how tokens are validated. This lets you check the tenant info on the fly for each request. Here’s how it works:

When a request comes in, grab the tenant ID

Look up the tenant’s settings (issuer, audience, etc.) from your database or wherever you’re storing it

Validate the token using those settings

This could be helpful: https://github.com/mikhailpetrusheuski/multi-tenant-keycloak and this blog post: https://medium.com/@mikhail.petrusheuski/multi-tenant-net-applications-with-keycloak-realms-my-hands-on-approach-e58e7e28e6a3








https://dev.to/marian_s/configuring-net-api-with-keycloak-f27


https://milanjovanovic.tech/blog/integrate-keycloak-with-aspnetcore-using-oauth-2


https://phasetwo.io/blog/multi-tenancy-with-keycloak-organizations/


https://github.com/p2-inc/keycloak-orgs


https://nikiforovall.blog/keycloak-authorization-services-dotnet/introduction.html







