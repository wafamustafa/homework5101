using System;
using System.Reflection;

namespace Assigment1_5101B_WafaMustafa_N01450753.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}