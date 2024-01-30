using System;
using System.Resources;

namespace WpfStaticLabelBindingWorking {
  public partial class MainWindow {
    private static readonly ResourceManager _rm = new ResourceManager(typeof(MainWindow));

    /// <summary>Hey</summary>
    public static String LabelHey {
      get { return _rm.GetString("LabelHey") ?? ""; }
    }

  }
}
