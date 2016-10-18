using System;
using System.Collections.Generic;
using Android.Widget;

namespace MvvMCalendar.Droid
{
    public partial class MainActivity
    {
        private List<TextView> btnList;
        private TextView txtMonth, txtViewTitle;
        private Button btnBack, btnNext, btnComplete;
        private TextView txtDate1,
            txtDate2,
            txtDate3,
            txtDate4,
            txtDate5,
            txtDate6,
            txtDate7,
            txtDate8,
            txtDate9,
            txtDate10,
            txtDate11,
            txtDate12,
            txtDate13,
            txtDate14,
            txtDate15,
            txtDate16,
            txtDate17,
            txtDate18,
            txtDate19,
            txtDate20,
            txtDate21,
            txtDate22,
            txtDate23,
            txtDate24,
            txtDate25,
            txtDate26,
            txtDate27,
            txtDate28,
            txtDate29,
            txtDate30,
            txtDate31,
            txtDate32,
            txtDate33,
            txtDate34,
            txtDate35;

        public TextView TxtViewTitle
            => txtViewTitle ?? (txtViewTitle = FindViewById<TextView>(Resource.Id.txtViewTitle));

        public TextView TxtMonth
        {
            get
            {
                return this.txtMonth
                       ?? (this.txtMonth = FindViewById<TextView>(Resource.Id.txtMonth));
            }
        }

        public TextView TxtDate1
        {
            get
            {
                return this.txtDate1
                       ?? (this.txtDate1 = FindViewById<TextView>(Resource.Id.txtDate1));
            }
        }

        public TextView TxtDate2
        {
            get
            {
                return this.txtDate2
                       ?? (this.txtDate2 = FindViewById<TextView>(Resource.Id.txtDate2));
            }
        }

        public TextView TxtDate3
        {
            get
            {
                return this.txtDate3
                       ?? (this.txtDate3 = FindViewById<TextView>(Resource.Id.txtDate3));
            }
        }

        public TextView TxtDate4
        {
            get
            {
                return this.txtDate4
                       ?? (this.txtDate4 = FindViewById<TextView>(Resource.Id.txtDate4));
            }
        }

        public TextView TxtDate5
        {
            get
            {
                return this.txtDate5
                       ?? (this.txtDate5 = FindViewById<TextView>(Resource.Id.txtDate5));
            }
        }

        public TextView TxtDate6
        {
            get
            {
                return this.txtDate6
                       ?? (this.txtDate6 = FindViewById<TextView>(Resource.Id.txtDate6));
            }
        }

        public TextView TxtDate7
        {
            get
            {
                return this.txtDate7
                       ?? (this.txtDate7 = FindViewById<TextView>(Resource.Id.txtDate7));
            }
        }

        public TextView TxtDate8
        {
            get
            {
                return this.txtDate8
                       ?? (this.txtDate8 = FindViewById<TextView>(Resource.Id.txtDate8));
            }
        }

        public TextView TxtDate9
        {
            get
            {
                return this.txtDate9
                       ?? (this.txtDate9 = FindViewById<TextView>(Resource.Id.txtDate9));
            }
        }

        public TextView TxtDate10
        {
            get
            {
                return this.txtDate10
                       ?? (this.txtDate10 = FindViewById<TextView>(Resource.Id.txtDate10));
            }
        }

        public TextView TxtDate11
        {
            get
            {
                return this.txtDate11
                       ?? (this.txtDate11 = FindViewById<TextView>(Resource.Id.txtDate11));
            }
        }

        public TextView TxtDate12
        {
            get
            {
                return this.txtDate12
                       ?? (this.txtDate12 = FindViewById<TextView>(Resource.Id.txtDate12));
            }
        }

        public TextView TxtDate13
        {
            get
            {
                return this.txtDate13
                       ?? (this.txtDate13 = FindViewById<TextView>(Resource.Id.txtDate13));
            }
        }

        public TextView TxtDate14
        {
            get
            {
                return this.txtDate14
                       ?? (this.txtDate14 = FindViewById<TextView>(Resource.Id.txtDate14));
            }
        }

        public TextView TxtDate15
        {
            get
            {
                return this.txtDate15
                       ?? (this.txtDate15 = FindViewById<TextView>(Resource.Id.txtDate15));
            }
        }

        public TextView TxtDate16
        {
            get
            {
                return this.txtDate16
                       ?? (this.txtDate16 = FindViewById<TextView>(Resource.Id.txtDate16));
            }
        }

        public TextView TxtDate17
        {
            get
            {
                return this.txtDate17
                       ?? (this.txtDate17 = FindViewById<TextView>(Resource.Id.txtDate17));
            }
        }

        public TextView TxtDate18
        {
            get
            {
                return this.txtDate18
                       ?? (this.txtDate18 = FindViewById<TextView>(Resource.Id.txtDate18));
            }
        }

        public TextView TxtDate19
        {
            get
            {
                return this.txtDate19
                       ?? (this.txtDate19 = FindViewById<TextView>(Resource.Id.txtDate19));
            }
        }

        public TextView TxtDate20
        {
            get
            {
                return this.txtDate20
                       ?? (this.txtDate20 = FindViewById<TextView>(Resource.Id.txtDate20));
            }
        }

        public TextView TxtDate21
        {
            get
            {
                return this.txtDate21
                       ?? (this.txtDate21 = FindViewById<TextView>(Resource.Id.txtDate21));
            }
        }

        public TextView TxtDate22
        {
            get
            {
                return this.txtDate22
                       ?? (this.txtDate22 = FindViewById<TextView>(Resource.Id.txtDate22));
            }
        }

        public TextView TxtDate23
        {
            get
            {
                return this.txtDate23
                       ?? (this.txtDate23 = FindViewById<TextView>(Resource.Id.txtDate23));
            }
        }

        public TextView TxtDate24
        {
            get
            {
                return this.txtDate24
                       ?? (this.txtDate24 = FindViewById<TextView>(Resource.Id.txtDate24));
            }
        }

        public TextView TxtDate25
        {
            get
            {
                return this.txtDate25
                       ?? (this.txtDate25 = FindViewById<TextView>(Resource.Id.txtDate25));
            }
        }

        public TextView TxtDate26
        {
            get
            {
                return this.txtDate26
                       ?? (this.txtDate26 = FindViewById<TextView>(Resource.Id.txtDate26));
            }
        }

        public TextView TxtDate27
        {
            get
            {
                return this.txtDate27
                       ?? (this.txtDate27 = FindViewById<TextView>(Resource.Id.txtDate27));
            }
        }

        public TextView TxtDate28
        {
            get
            {
                return this.txtDate28
                       ?? (this.txtDate28 = FindViewById<TextView>(Resource.Id.txtDate28));
            }
        }

        public TextView TxtDate29
        {
            get
            {
                return this.txtDate29
                       ?? (this.txtDate29 = FindViewById<TextView>(Resource.Id.txtDate29));
            }
        }

        public TextView TxtDate30
        {
            get
            {
                return this.txtDate30
                       ?? (this.txtDate30 = FindViewById<TextView>(Resource.Id.txtDate30));
            }
        }

        public TextView TxtDate31
        {
            get
            {
                return this.txtDate31
                       ?? (this.txtDate31 = FindViewById<TextView>(Resource.Id.txtDate31));
            }
        }

        public TextView TxtDate32
        {
            get
            {
                return this.txtDate32
                       ?? (this.txtDate32 = FindViewById<TextView>(Resource.Id.txtDate32));
            }
        }

        public TextView TxtDate33
        {
            get
            {
                return this.txtDate33
                       ?? (this.txtDate33 = FindViewById<TextView>(Resource.Id.txtDate33));
            }
        }

        public TextView TxtDate34
        {
            get
            {
                return this.txtDate34
                       ?? (this.txtDate34 = FindViewById<TextView>(Resource.Id.txtDate34));
            }
        }

        public TextView TxtDate35
        {
            get
            {
                return this.txtDate35
                       ?? (this.txtDate35 = FindViewById<TextView>(Resource.Id.txtDate35));
            }
        }


        public Button BtnNext
        {
            get
            {
                return this.btnNext
                       ?? (this.btnNext = FindViewById<Button>(Resource.Id.btnNext));
            }
        }

        public Button BtnBack
        {
            get
            {
                return this.btnBack
                       ?? (this.btnBack = FindViewById<Button>(Resource.Id.btnBack));
            }
        }
    }
}
