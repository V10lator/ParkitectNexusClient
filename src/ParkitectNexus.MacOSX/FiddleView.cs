﻿
using System;
using System.Collections.Generic;
using System.Linq;
using MonoMac.Foundation;
using MonoMac.AppKit;

namespace ParkitectNexus.MacOSX
{
    public partial class FiddleView : MonoMac.AppKit.NSView
    {
        //
        // I'm using FiddleView.xib for testing view hierarchies in Xcode.
        // Do not instantiate this view or things might explode.
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //

        #region Constructors

        // Called when created from unmanaged code
        public FiddleView(IntPtr handle) : base(handle)
        {
            Initialize();
        }
		
        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public FiddleView(NSCoder coder) : base(coder)
        {
            Initialize();
        }
		
        // Shared initialization code
        void Initialize()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

