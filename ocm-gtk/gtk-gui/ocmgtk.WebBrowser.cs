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
    
    
    public partial class WebBrowser {
        
        private Gtk.VBox vbox2;
        
        private Gtk.ScrolledWindow browserScroll;
        
        private Gtk.Statusbar browserStatus;
        
        private Gtk.ProgressBar browserProgress;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget ocmgtk.WebBrowser
            this.WidthRequest = 800;
            this.HeightRequest = 500;
            this.Name = "ocmgtk.WebBrowser";
            this.Title = Mono.Unix.Catalog.GetString("WebBrowser");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            // Container child ocmgtk.WebBrowser.Gtk.Container+ContainerChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.browserScroll = new Gtk.ScrolledWindow();
            this.browserScroll.CanFocus = true;
            this.browserScroll.Name = "browserScroll";
            this.browserScroll.ShadowType = ((Gtk.ShadowType)(1));
            this.vbox2.Add(this.browserScroll);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox2[this.browserScroll]));
            w1.Position = 0;
            // Container child vbox2.Gtk.Box+BoxChild
            this.browserStatus = new Gtk.Statusbar();
            this.browserStatus.Name = "browserStatus";
            this.browserStatus.Spacing = 6;
            // Container child browserStatus.Gtk.Box+BoxChild
            this.browserProgress = new Gtk.ProgressBar();
            this.browserProgress.WidthRequest = 150;
            this.browserProgress.Name = "browserProgress";
            this.browserStatus.Add(this.browserProgress);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.browserStatus[this.browserProgress]));
            w2.Position = 2;
            w2.Expand = false;
            w2.Fill = false;
            this.vbox2.Add(this.browserStatus);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox2[this.browserStatus]));
            w3.Position = 1;
            w3.Expand = false;
            w3.Fill = false;
            this.Add(this.vbox2);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 812;
            this.DefaultHeight = 627;
            this.Show();
        }
    }
}
