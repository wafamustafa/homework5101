using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Assigment1_5101B_WafaMustafa_N01450753.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}