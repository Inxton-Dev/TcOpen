using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace TcoCoreTests
{
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "MAIN", "TcoCoreTests", TypeComplexityEnum.Complex)]
	public partial class MAIN : Vortex.Connector.IVortexObject, IMAIN, IShadowMAIN, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		public string Symbol
		{
			get;
			protected set;
		}

		public string HumanReadable
		{
			get
			{
				return TcoCoreTestsTwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		TcoContext_Waveform __TcoContext_Waveform;
		public TcoContext_Waveform _TcoContext_Waveform
		{
			get
			{
				return __TcoContext_Waveform;
			}
		}

		ITcoContext_Waveform IMAIN._TcoContext_Waveform
		{
			get
			{
				return _TcoContext_Waveform;
			}
		}

		IShadowTcoContext_Waveform IShadowMAIN._TcoContext_Waveform
		{
			get
			{
				return _TcoContext_Waveform;
			}
		}

		TcoContextTest __TcoContextTest_A;
		public TcoContextTest _TcoContextTest_A
		{
			get
			{
				return __TcoContextTest_A;
			}
		}

		ITcoContextTest IMAIN._TcoContextTest_A
		{
			get
			{
				return _TcoContextTest_A;
			}
		}

		IShadowTcoContextTest IShadowMAIN._TcoContextTest_A
		{
			get
			{
				return _TcoContextTest_A;
			}
		}

		TcoContextTest __TcoContextTest_B;
		public TcoContextTest _TcoContextTest_B
		{
			get
			{
				return __TcoContextTest_B;
			}
		}

		ITcoContextTest IMAIN._TcoContextTest_B
		{
			get
			{
				return _TcoContextTest_B;
			}
		}

		IShadowTcoContextTest IShadowMAIN._TcoContextTest_B
		{
			get
			{
				return _TcoContextTest_B;
			}
		}

		public void LazyOnlineToShadow()
		{
			_TcoContext_Waveform.LazyOnlineToShadow();
			_TcoContextTest_A.LazyOnlineToShadow();
			_TcoContextTest_B.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			_TcoContext_Waveform.LazyShadowToOnline();
			_TcoContextTest_A.LazyShadowToOnline();
			_TcoContextTest_B.LazyShadowToOnline();
		}

		public PlainMAIN CreatePlainerType()
		{
			var cloned = new PlainMAIN();
			cloned._TcoContext_Waveform = _TcoContext_Waveform.CreatePlainerType();
			cloned._TcoContextTest_A = _TcoContextTest_A.CreatePlainerType();
			cloned._TcoContextTest_B = _TcoContextTest_B.CreatePlainerType();
			return cloned;
		}

		protected PlainMAIN CreatePlainerType(PlainMAIN cloned)
		{
			cloned._TcoContext_Waveform = _TcoContext_Waveform.CreatePlainerType();
			cloned._TcoContextTest_A = _TcoContextTest_A.CreatePlainerType();
			cloned._TcoContextTest_B = _TcoContextTest_B.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		protected Vortex.Connector.IVortexObject @Parent
		{
			get;
			set;
		}

		public Vortex.Connector.IVortexObject GetParent()
		{
			return this.@Parent;
		}

		private System.Collections.Generic.List<Vortex.Connector.IVortexObject> @Children
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexObject> @GetChildren()
		{
			return this.@Children;
		}

		public void AddChild(Vortex.Connector.IVortexObject vortexObject)
		{
			this.@Children.Add(vortexObject);
		}

		private System.Collections.Generic.List<Vortex.Connector.IValueTag> @ValueTags
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IValueTag> GetValueTags()
		{
			return this.@ValueTags;
		}

		public void AddValueTag(Vortex.Connector.IValueTag valueTag)
		{
			this.@ValueTags.Add(valueTag);
		}

		protected Vortex.Connector.IConnector @Connector
		{
			get;
			set;
		}

		public Vortex.Connector.IConnector GetConnector()
		{
			return this.@Connector;
		}

		public void FlushPlainToOnline(TcoCoreTests.PlainMAIN source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(TcoCoreTests.PlainMAIN source)
		{
			source.CopyPlainToShadow(this);
		}

		public void FlushShadowToOnline()
		{
			this.LazyShadowToOnline();
			this.Write();
		}

		public void FlushOnlineToShadow()
		{
			this.Read();
			this.LazyOnlineToShadow();
		}

		public void FlushOnlineToPlain(TcoCoreTests.PlainMAIN source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		protected System.String @SymbolTail
		{
			get;
			set;
		}

		public System.String GetSymbolTail()
		{
			return this.SymbolTail;
		}

		public System.String AttributeName
		{
			get
			{
				return TcoCoreTestsTwinController.Translator.Translate(_AttributeName).Interpolate(this);
			}

			set
			{
				_AttributeName = value;
			}
		}

		private System.String _AttributeName
		{
			get;
			set;
		}

		public MAIN(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			__TcoContext_Waveform = new TcoContext_Waveform(this, "", "_TcoContext_Waveform");
			__TcoContextTest_A = new TcoContextTest(this, "", "_TcoContextTest_A");
			__TcoContextTest_B = new TcoContextTest(this, "", "_TcoContextTest_B");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public MAIN()
		{
			PexPreConstructorParameterless();
			__TcoContext_Waveform = new TcoContext_Waveform();
			__TcoContextTest_A = new TcoContextTest();
			__TcoContextTest_B = new TcoContextTest();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcMAIN
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcMAIN()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IMAIN : Vortex.Connector.IVortexOnlineObject
	{
		ITcoContext_Waveform _TcoContext_Waveform
		{
			get;
		}

		ITcoContextTest _TcoContextTest_A
		{
			get;
		}

		ITcoContextTest _TcoContextTest_B
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		TcoCoreTests.PlainMAIN CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(TcoCoreTests.PlainMAIN source);
		void FlushOnlineToPlain(TcoCoreTests.PlainMAIN source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowMAIN : Vortex.Connector.IVortexShadowObject
	{
		IShadowTcoContext_Waveform _TcoContext_Waveform
		{
			get;
		}

		IShadowTcoContextTest _TcoContextTest_A
		{
			get;
		}

		IShadowTcoContextTest _TcoContextTest_B
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		TcoCoreTests.PlainMAIN CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(TcoCoreTests.PlainMAIN source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainMAIN : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		PlainTcoContext_Waveform __TcoContext_Waveform;
		public PlainTcoContext_Waveform _TcoContext_Waveform
		{
			get
			{
				return __TcoContext_Waveform;
			}

			set
			{
				if (__TcoContext_Waveform != value)
				{
					__TcoContext_Waveform = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_TcoContext_Waveform)));
				}
			}
		}

		PlainTcoContextTest __TcoContextTest_A;
		public PlainTcoContextTest _TcoContextTest_A
		{
			get
			{
				return __TcoContextTest_A;
			}

			set
			{
				if (__TcoContextTest_A != value)
				{
					__TcoContextTest_A = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_TcoContextTest_A)));
				}
			}
		}

		PlainTcoContextTest __TcoContextTest_B;
		public PlainTcoContextTest _TcoContextTest_B
		{
			get
			{
				return __TcoContextTest_B;
			}

			set
			{
				if (__TcoContextTest_B != value)
				{
					__TcoContextTest_B = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_TcoContextTest_B)));
				}
			}
		}

		public void CopyPlainToCyclic(TcoCoreTests.MAIN target)
		{
			_TcoContext_Waveform.CopyPlainToCyclic(target._TcoContext_Waveform);
			_TcoContextTest_A.CopyPlainToCyclic(target._TcoContextTest_A);
			_TcoContextTest_B.CopyPlainToCyclic(target._TcoContextTest_B);
		}

		public void CopyPlainToCyclic(TcoCoreTests.IMAIN target)
		{
			this.CopyPlainToCyclic((TcoCoreTests.MAIN)target);
		}

		public void CopyPlainToShadow(TcoCoreTests.MAIN target)
		{
			_TcoContext_Waveform.CopyPlainToShadow(target._TcoContext_Waveform);
			_TcoContextTest_A.CopyPlainToShadow(target._TcoContextTest_A);
			_TcoContextTest_B.CopyPlainToShadow(target._TcoContextTest_B);
		}

		public void CopyPlainToShadow(TcoCoreTests.IShadowMAIN target)
		{
			this.CopyPlainToShadow((TcoCoreTests.MAIN)target);
		}

		public void CopyCyclicToPlain(TcoCoreTests.MAIN source)
		{
			_TcoContext_Waveform.CopyCyclicToPlain(source._TcoContext_Waveform);
			_TcoContextTest_A.CopyCyclicToPlain(source._TcoContextTest_A);
			_TcoContextTest_B.CopyCyclicToPlain(source._TcoContextTest_B);
		}

		public void CopyCyclicToPlain(TcoCoreTests.IMAIN source)
		{
			this.CopyCyclicToPlain((TcoCoreTests.MAIN)source);
		}

		public void CopyShadowToPlain(TcoCoreTests.MAIN source)
		{
			_TcoContext_Waveform.CopyShadowToPlain(source._TcoContext_Waveform);
			_TcoContextTest_A.CopyShadowToPlain(source._TcoContextTest_A);
			_TcoContextTest_B.CopyShadowToPlain(source._TcoContextTest_B);
		}

		public void CopyShadowToPlain(TcoCoreTests.IShadowMAIN source)
		{
			this.CopyShadowToPlain((TcoCoreTests.MAIN)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainMAIN()
		{
			__TcoContext_Waveform = new PlainTcoContext_Waveform();
			__TcoContextTest_A = new PlainTcoContextTest();
			__TcoContextTest_B = new PlainTcoContextTest();
		}
	}
}