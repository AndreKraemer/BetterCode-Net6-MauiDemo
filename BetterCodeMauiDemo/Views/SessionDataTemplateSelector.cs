using Microsoft.Maui.Controls;
using BetterCodeMauiDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterCodeMauiDemo.Views
{
    public class SessionDataTemplateSelector: DataTemplateSelector
    {
        public DataTemplate SessionTemplate { get; set; }
        public DataTemplate BreakTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return (item as Session)?.Speaker != null ? SessionTemplate : BreakTemplate;
        }
    }
}
