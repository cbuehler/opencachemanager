// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace ocmgtk {
    
    
    public partial class HTMLWidget {
        
        private Gtk.Frame frame4;
        
        private Gtk.ScrolledWindow htmlScroll;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget ocmgtk.HTMLWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "ocmgtk.HTMLWidget";
            // Container child ocmgtk.HTMLWidget.Gtk.Container+ContainerChild
            this.frame4 = new Gtk.Frame();
            this.frame4.Name = "frame4";
            this.frame4.ShadowType = ((Gtk.ShadowType)(0));
            this.frame4.LabelYalign = 0F;
            // Container child frame4.Gtk.Container+ContainerChild
            this.htmlScroll = new Gtk.ScrolledWindow();
            this.htmlScroll.CanFocus = true;
            this.htmlScroll.Name = "htmlScroll";
            this.htmlScroll.ShadowType = ((Gtk.ShadowType)(1));
            this.frame4.Add(this.htmlScroll);
            this.Add(this.frame4);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Hide();
        }
    }
}
