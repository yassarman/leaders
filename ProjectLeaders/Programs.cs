using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ProjectLeaders
{
    class Programs
    {
        public string ProgDesc;
        public int ImageSourceId;

        public Programs(string ProgDesc,int ImageSourceId)
        {
            
            this.ProgDesc = ProgDesc;
            this.ImageSourceId = ImageSourceId;

        }


    }
}