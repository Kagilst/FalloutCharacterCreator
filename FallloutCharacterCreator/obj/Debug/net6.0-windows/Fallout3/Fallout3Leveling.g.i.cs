﻿#pragma checksum "..\..\..\..\Fallout3\Fallout3Leveling.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B3048D93B94A2C24D2641FAFE7EAD71027409311"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FallloutCharacterCreator.Fallout3;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace FallloutCharacterCreator.Fallout3 {
    
    
    /// <summary>
    /// Fallout3Leveling
    /// </summary>
    public partial class Fallout3Leveling : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Viewbox SkillBooksViewbox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border SkillBooksBorder;
        
        #line default
        #line hidden
        
        
        #line 319 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BooksSave;
        
        #line default
        #line hidden
        
        
        #line 331 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Viewbox LvlViewbox;
        
        #line default
        #line hidden
        
        
        #line 336 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblMain;
        
        #line default
        #line hidden
        
        
        #line 730 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExtraPerks;
        
        #line default
        #line hidden
        
        
        #line 731 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SkillBooks;
        
        #line default
        #line hidden
        
        
        #line 732 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LevelUp;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FallloutCharacterCreator;V1.0.0.0;component/fallout3/fallout3leveling.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SkillBooksViewbox = ((System.Windows.Controls.Viewbox)(target));
            return;
            case 2:
            this.SkillBooksBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.BooksSave = ((System.Windows.Controls.Button)(target));
            
            #line 319 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            this.BooksSave.Click += new System.Windows.RoutedEventHandler(this.BooksSave_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LvlViewbox = ((System.Windows.Controls.Viewbox)(target));
            return;
            case 5:
            this.lblMain = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            
            #line 490 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DecreaseBarter);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 497 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DecreaseBigGuns);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 504 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DecreaseEnergyWeapons);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 511 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DecreaseExplosives);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 518 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DecreaseLockpick);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 525 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DecreaseMedicine);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 532 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DecreaseMeleeWeapons);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 539 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DecreaseRepair);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 546 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DecreaseScience);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 553 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DecreaseSmallGuns);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 560 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DecreaseSneak);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 567 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DecreaseSpeech);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 574 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DecreaseUnarmed);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 630 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IncreaseBarter);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 637 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IncreaseBigGuns);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 644 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IncreaseEnergyWeapons);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 651 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IncreaseExplosives);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 658 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IncreaseLockpick);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 665 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IncreaseMedicine);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 672 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IncreaseMeleeWeapons);
            
            #line default
            #line hidden
            return;
            case 26:
            
            #line 679 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IncreaseRepair);
            
            #line default
            #line hidden
            return;
            case 27:
            
            #line 686 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IncreaseScience);
            
            #line default
            #line hidden
            return;
            case 28:
            
            #line 693 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IncreaseSmallGuns);
            
            #line default
            #line hidden
            return;
            case 29:
            
            #line 700 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IncreaseSneak);
            
            #line default
            #line hidden
            return;
            case 30:
            
            #line 707 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IncreaseSpeech);
            
            #line default
            #line hidden
            return;
            case 31:
            
            #line 714 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IncreaseUnarmed);
            
            #line default
            #line hidden
            return;
            case 32:
            this.ExtraPerks = ((System.Windows.Controls.Button)(target));
            
            #line 730 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            this.ExtraPerks.Click += new System.Windows.RoutedEventHandler(this.ExtraPerks_Click);
            
            #line default
            #line hidden
            return;
            case 33:
            this.SkillBooks = ((System.Windows.Controls.Button)(target));
            
            #line 731 "..\..\..\..\Fallout3\Fallout3Leveling.xaml"
            this.SkillBooks.Click += new System.Windows.RoutedEventHandler(this.SkillBooks_Click);
            
            #line default
            #line hidden
            return;
            case 34:
            this.LevelUp = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

