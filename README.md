# Web API Servics

# origin is the port or the domain

# Access to XMLHttpRequest at 'http://127.0.0.1:82/api/employee' from origin 'http://localhost:51728' has been blocked by CORS policy: No 'Access-Control-Allow-Origin' header is present on the requested resource.

# This Error because origin is changed from  '82'  to '51728' ITs  blocked by CORS policy to avoid third-party  & hacking


# this code for allow CORS origin 
# (CORS) Cross-Origin Resource Sharing 

# its write in  <system.webServer> in Web.Config
 
{
<httpProtocol>
		  <customHeaders>
			  <add name="Access-Control-Allow-Origin" value="*"/>
			  <add name="Access-Control-Allow-Headers" value="Content-Type"/>
			  <add name="Access-Control-Allow-Methods" value="GET,POST,PUT,DELETE,OPTIONS"/>

		  </customHeaders>
	  </httpProtocol>
}

# in Global.asax

{
 protected void Application_BeginRequest()
        {
            // condition for Make sure its preflight request
            if(Request.Headers.AllKeys.Contains("origin") && Request.HttpMethod == "OPTIONS")
            {
                Response.Flush();
            }
        }
}
