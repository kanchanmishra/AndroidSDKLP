using System;

using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using System.Xml;


namespace Com.Liveperson.Infra.UI.View.Utils
{
    public partial class ItemsView
    {
        
        public partial class RecyclerViewAdapter 
        {
             public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup viewGroup, int i)
                {

                return OnCreateViewHolder(viewGroup, i);

                /*FrameLayout F = new FrameLayout(viewGroup.Context);
                
                    return new MyViewHolder(LayoutInflater.From(viewGroup.Context).Inflate(1, viewGroup, false));
                    */
                }

        }
    }
    
    /*

    public class MyViewHolder: RecyclerView.ViewHolder
    {
        
        
      //  private Android.Content.Context _context = new Android.a;
        public TextView title, year, genre;
       // FrameLayout F = new FrameLayout(_context);
        public MyViewHolder(Android.Views.View view) : base(view)
        {
        
            title = (TextView)view.FindViewById(1);
           
        }
}
*/
}
