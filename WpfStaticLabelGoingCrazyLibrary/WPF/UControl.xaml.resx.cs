using System;
using System.Resources;

namespace WpfStaticLabelGoingCrazyLibrary.WPF {
  public partial class UControl {
    private static readonly ResourceManager _rm = new ResourceManager(typeof(UControl));

    /// <summary>Hey</summary>
    public static String LabelHey {
      get { return _rm.GetString("LabelHey") ?? ""; }
    }

  }
}
