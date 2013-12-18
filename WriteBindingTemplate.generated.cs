﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WriteAssemblyBinding
{
    using System;
    
    #line 2 "..\..\WriteBindingTemplate.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    using System.Linq;
    
    #line 3 "..\..\WriteBindingTemplate.cshtml"
    using System.Reflection;
    
    #line default
    #line hidden
    
    #line 4 "..\..\WriteBindingTemplate.cshtml"
    using System.Text;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class WriteBindingTemplate : RazorGenerator.Templating.RazorTemplateBase
    {
#line hidden

        #line 5 "..\..\WriteBindingTemplate.cshtml"

	public List<Assembly> Model { get; set; }

	private static string GetPublicKeyToken(Assembly assembly)
	{
		var sb = new StringBuilder();
		var pk = assembly.GetName().GetPublicKeyToken();
		for (var i = 0; i < pk.GetLength(0); i++)
			sb.AppendFormat("{0:x2}", pk[i]);
		return sb.ToString();
	}

        #line default
        #line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");





WriteLiteral("\r\n \r\n\r\n<assemblyBinding xmlns=\"urn:schemas-microsoft-com:asm.v1\">\r\n");


            
            #line 20 "..\..\WriteBindingTemplate.cshtml"
 foreach (var a in Model)
{
	if (string.IsNullOrEmpty(GetPublicKeyToken(a)))
	{
		continue;
	}

            
            #line default
            #line hidden
WriteLiteral("\t<dependentAssembly>\r\n\t\t<assemblyIdentity name=\"");


            
            #line 27 "..\..\WriteBindingTemplate.cshtml"
                     Write(a.GetName().Name);

            
            #line default
            #line hidden
WriteLiteral("\" publicKeyToken=\"");


            
            #line 27 "..\..\WriteBindingTemplate.cshtml"
                                                        Write(GetPublicKeyToken(a));

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n\t\t<bindingRedirect oldVersion=\"0.0.0.0-");


            
            #line 28 "..\..\WriteBindingTemplate.cshtml"
                                  Write(a.GetName().Version.ToString());

            
            #line default
            #line hidden
WriteLiteral("\" newVersion=\"");


            
            #line 28 "..\..\WriteBindingTemplate.cshtml"
                                                                               Write(a.GetName().Version.ToString());

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n\t</dependentAssembly>\r\n");


            
            #line 30 "..\..\WriteBindingTemplate.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("</assemblyBinding>");


        }
    }
}
#pragma warning restore 1591