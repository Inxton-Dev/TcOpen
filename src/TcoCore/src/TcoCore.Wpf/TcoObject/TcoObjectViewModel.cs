﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vortex.Presentation.Wpf;
using Vortex.Connector;
using System.Windows.Data;
using System.Windows.Markup;
using System.Globalization;
using System.Windows;

namespace TcoCore
{
    public class TcoObjectViewModel : RenderableViewModel
    {
        public TcoObjectViewModel()
        {
            
        }
       
        private void Update()
        {
            Tasks = TcoObject.GetChildren<TcoTask>();
            Children = TcoObject.GetChildren<TcoObject>(Tasks);
        }

        public TcoObject TcoObject { get; private set; }

        public override object Model { get => TcoObject; set { TcoObject  = value as TcoObject; Update(); } }

        IEnumerable<TcoTask> tasks;
        public IEnumerable<TcoTask> Tasks
        {
            get => tasks;

            private set
            {
                if (tasks == value)
                {
                    return;
                }

                SetProperty(ref tasks, value);
            }
        }

        public IEnumerable<TcoObject> Children { get; private set; }
       
    }
}
