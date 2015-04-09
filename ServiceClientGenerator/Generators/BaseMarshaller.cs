﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class BaseMarshaller : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 7 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"

    // Adds the neccesary namespaces for the marshaller
protected void AddCommonUsingStatements()
    {

        
        #line default
        #line hidden
        
        #line 11 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.Globalization;\r\nus" +
        "ing System.IO;\r\nusing System.Text;\r\nusing System.Xml.Serialization;\r\n\r\nusing ");

        
        #line default
        #line hidden
        
        #line 19 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));

        
        #line default
        #line hidden
        
        #line 19 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(".Model;\r\nusing Amazon.Runtime;\r\nusing Amazon.Runtime.Internal;\r\nusing Amazon.Runt" +
        "ime.Internal.Transform;\r\nusing Amazon.Runtime.Internal.Util;\r\n");

        
        #line default
        #line hidden
        
        #line 24 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"

    }

        
        #line default
        #line hidden
        
        #line 28 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"

    // Generates code to add members to the header of the request
    // If it's a custom marshaller then it calls the custom marshaller first
	protected void ProcessHeaderMembers(string variableName, IEnumerable<Member> members)
	{
		foreach(var member in members)
		{

        
        #line default
        #line hidden
        
        #line 35 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("\t\t\r\n\t\t\tif(");

        
        #line default
        #line hidden
        
        #line 36 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 36 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(".IsSet");

        
        #line default
        #line hidden
        
        #line 36 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 36 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("())\r\n");

        
        #line default
        #line hidden
        
        #line 37 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"

            if (member.CustomMarshallerTransformation != null)
            {

        
        #line default
        #line hidden
        
        #line 40 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("\t\t\t\trequest.Headers[\"");

        
        #line default
        #line hidden
        
        #line 41 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 41 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("\"] = ");

        
        #line default
        #line hidden
        
        #line 41 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.CustomMarshallerTransformation));

        
        #line default
        #line hidden
        
        #line 41 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("(");

        
        #line default
        #line hidden
        
        #line 41 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 41 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(".");

        
        #line default
        #line hidden
        
        #line 41 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 41 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(");\r\n");

        
        #line default
        #line hidden
        
        #line 42 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
        
            }
            else
            {

        
        #line default
        #line hidden
        
        #line 46 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("\t\t\t\trequest.Headers[\"");

        
        #line default
        #line hidden
        
        #line 47 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 47 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("\"] = ");

        
        #line default
        #line hidden
        
        #line 47 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 47 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(".");

        
        #line default
        #line hidden
        
        #line 47 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 47 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(";\r\n");

        
        #line default
        #line hidden
        
        #line 48 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
			
		    }
        }
	}

    // Generates code to add the operation's requestURIMembers to the uriResourcePath
	protected void ProcessUriMembers(string variableName, Operation operation)
	{
		foreach(var member in operation.RequestUriMembers)
		{

        
        #line default
        #line hidden
        
        #line 58 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("\t\t\turiResourcePath = uriResourcePath.Replace(\"{");

        
        #line default
        #line hidden
        
        #line 59 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 59 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("}\", ");

        
        #line default
        #line hidden
        
        #line 59 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 59 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(".IsSet");

        
        #line default
        #line hidden
        
        #line 59 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 59 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("() ? StringUtils.From");

        
        #line default
        #line hidden
        
        #line 59 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.GetPrimitiveType()));

        
        #line default
        #line hidden
        
        #line 59 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("(");

        
        #line default
        #line hidden
        
        #line 59 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 59 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(".");

        
        #line default
        #line hidden
        
        #line 59 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 59 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(") : string.Empty);\r\n");

        
        #line default
        #line hidden
        
        #line 60 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
			
		}
	}

	protected void ProcessRequestUri(Operation operation)
	{

        
        #line default
        #line hidden
        
        #line 66 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("\t\t\tstring uriResourcePath = \"");

        
        #line default
        #line hidden
        
        #line 67 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(operation.RequestUri));

        
        #line default
        #line hidden
        
        #line 67 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("\";\r\n");

        
        #line default
        #line hidden
        
        #line 68 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"

		foreach(var staticQueryParam in operation.StaticQueryParameters)
		{

        
        #line default
        #line hidden
        
        #line 71 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("\t\t\trequest.AddSubResource(\"");

        
        #line default
        #line hidden
        
        #line 72 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(staticQueryParam.Key));

        
        #line default
        #line hidden
        
        #line 72 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("\", \"");

        
        #line default
        #line hidden
        
        #line 72 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(staticQueryParam.Value));

        
        #line default
        #line hidden
        
        #line 72 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("\");\r\n");

        
        #line default
        #line hidden
        
        #line 73 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
			
		}
	}

    // Generates code to add any operation query members to the query string for the request
    // If the marshaller is customized, it marshalls the value before changing it to a string
	protected void ProcessQueryStringMembers(string variableName, Operation operation)
	{
		if(operation.RequestHasQueryStringMembers)		
		{
			foreach(var member in operation.RequestQueryStringMembers)
			{

        
        #line default
        #line hidden
        
        #line 85 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("\t\t\t\r\n\t\t\tif (");

        
        #line default
        #line hidden
        
        #line 86 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 86 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(".IsSet");

        
        #line default
        #line hidden
        
        #line 86 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 86 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("())\r\n");

        
        #line default
        #line hidden
        
        #line 87 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"

                if (member.CustomMarshallerTransformation != null)
                {

        
        #line default
        #line hidden
        
        #line 90 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("\t\t\t\trequest.Parameters.Add(\"");

        
        #line default
        #line hidden
        
        #line 91 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 91 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("\", ");

        
        #line default
        #line hidden
        
        #line 91 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.CustomMarshallerTransformation));

        
        #line default
        #line hidden
        
        #line 91 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("(");

        
        #line default
        #line hidden
        
        #line 91 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 91 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(".");

        
        #line default
        #line hidden
        
        #line 91 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 91 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("));\r\n");

        
        #line default
        #line hidden
        
        #line 92 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
        
                }
                else
                {

        
        #line default
        #line hidden
        
        #line 96 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("\t\t\t\trequest.Parameters.Add(\"");

        
        #line default
        #line hidden
        
        #line 97 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 97 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("\", StringUtils.From");

        
        #line default
        #line hidden
        
        #line 97 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.GetPrimitiveType()));

        
        #line default
        #line hidden
        
        #line 97 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("(");

        
        #line default
        #line hidden
        
        #line 97 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 97 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(".");

        
        #line default
        #line hidden
        
        #line 97 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 97 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
this.Write("));\r\n");

        
        #line default
        #line hidden
        
        #line 98 "C:\code\dotnet\release\sdk\src\ServiceClientGenerator\Generators\BaseMarshaller.tt"
			
				}
			}
		}
	}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
