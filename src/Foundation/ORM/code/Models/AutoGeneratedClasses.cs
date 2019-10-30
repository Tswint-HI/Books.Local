





#pragma warning disable 1591
#pragma warning disable 0108
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Team Development for Sitecore.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;   
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Fields;
using Sitecore.Globalization;
using Sitecore.Data;



namespace Books.Foundation.Orm.Models
{

	public partial interface IGlassBase{
		
		[SitecoreId]
		Guid Id{ get; }

		[SitecoreInfo(SitecoreInfoType.Language)]
        Language Language{ get; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        int Version { get; }

		[SitecoreInfo(SitecoreInfoType.Url)]
        string Url { get; }
	}

	public abstract partial class GlassBase : IGlassBase{
		
		[SitecoreId]
		public virtual Guid Id{ get; set;}

		[SitecoreInfo(SitecoreInfoType.Language)]
        public virtual Language Language{ get; private set; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        public virtual int Version { get; private set; }

		[SitecoreInfo(SitecoreInfoType.Url)]
        public virtual string Url { get; private set; }
	}
}
namespace Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base
{


 	/// <summary>
	/// I_Base_Content Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/User Defined/Base/_Base Content</para>	
	/// <para>ID: 2d0be1ce-5197-4110-a507-54fe2c4f753d</para>	
	/// </summary>
	[SitecoreType(TemplateId=I_Base_ContentConstants.TemplateIdString, AutoMap = true )] //, Cachable = true
	public partial interface I_Base_Content : IGlassBase 
	{
								/// <summary>
					/// The ContentBody field.
					/// <para></para>
					/// <para>Field Type: Multi-Line Text</para>		
					/// <para>Field ID: 8af829a4-3a05-4df4-8028-9505c7fd3d65</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(I_Base_ContentConstants.ContentBodyFieldName)]
					string ContentBody  {get; set;}
			
				}


	public static partial class I_Base_ContentConstants{

			public const string TemplateIdString = "2d0be1ce-5197-4110-a507-54fe2c4f753d";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "_Base Content";

					
			public static readonly ID ContentBodyFieldId = new ID("8af829a4-3a05-4df4-8028-9505c7fd3d65");
			public const string ContentBodyFieldName = "ContentBody";
			
			

	}

	
	/// <summary>
	/// _Base_Content
	/// <para></para>
	/// <para>Path: /sitecore/templates/User Defined/Base/_Base Content</para>	
	/// <para>ID: 2d0be1ce-5197-4110-a507-54fe2c4f753d</para>	
	/// </summary>
	[SitecoreType(TemplateId=I_Base_ContentConstants.TemplateIdString, AutoMap = true)] //, Cachable = true
	public partial class _Base_Content  : GlassBase, I_Base_Content 
	{
	   
						/// <summary>
				/// The ContentBody field.
				/// <para></para>
				/// <para>Field Type: Multi-Line Text</para>		
				/// <para>Field ID: 8af829a4-3a05-4df4-8028-9505c7fd3d65</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(I_Base_ContentConstants.ContentBodyFieldName)]
				public virtual string ContentBody  {get; set;}
					
			
	}
}
namespace Books.Foundation.Orm.Models.sitecore.templates.Feature.Carousel
{


 	/// <summary>
	/// ICarousel Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/Feature/Carousel/Carousel</para>	
	/// <para>ID: 49393afb-4a02-4f34-acf1-fec86916bb47</para>	
	/// </summary>
	[SitecoreType(TemplateId=ICarouselConstants.TemplateIdString, AutoMap = true )] //, Cachable = true
	public partial interface ICarousel : IGlassBase 
	{
								/// <summary>
					/// The Caption field.
					/// <para></para>
					/// <para>Field Type: Single-Line Text</para>		
					/// <para>Field ID: 24071b88-2093-4f1e-9b6a-f3aa274a64ac</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(ICarouselConstants.CaptionFieldName)]
					string Caption  {get; set;}
			
								/// <summary>
					/// The Image field.
					/// <para></para>
					/// <para>Field Type: Image</para>		
					/// <para>Field ID: edaf25d3-c80a-45b2-8d90-7ca4db15080e</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(ICarouselConstants.ImageFieldName)]
					Image Image  {get; set;}
			
				}


	public static partial class ICarouselConstants{

			public const string TemplateIdString = "49393afb-4a02-4f34-acf1-fec86916bb47";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Carousel";

					
			public static readonly ID CaptionFieldId = new ID("24071b88-2093-4f1e-9b6a-f3aa274a64ac");
			public const string CaptionFieldName = "Caption";
			
					
			public static readonly ID ImageFieldId = new ID("edaf25d3-c80a-45b2-8d90-7ca4db15080e");
			public const string ImageFieldName = "Image";
			
			

	}

	
	/// <summary>
	/// Carousel
	/// <para></para>
	/// <para>Path: /sitecore/templates/Feature/Carousel/Carousel</para>	
	/// <para>ID: 49393afb-4a02-4f34-acf1-fec86916bb47</para>	
	/// </summary>
	[SitecoreType(TemplateId=ICarouselConstants.TemplateIdString, AutoMap = true)] //, Cachable = true
	public partial class Carousel  : GlassBase, ICarousel 
	{
	   
						/// <summary>
				/// The Caption field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: 24071b88-2093-4f1e-9b6a-f3aa274a64ac</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(ICarouselConstants.CaptionFieldName)]
				public virtual string Caption  {get; set;}
					
						/// <summary>
				/// The Image field.
				/// <para></para>
				/// <para>Field Type: Image</para>		
				/// <para>Field ID: edaf25d3-c80a-45b2-8d90-7ca4db15080e</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(ICarouselConstants.ImageFieldName)]
				public virtual Image Image  {get; set;}
					
			
	}
}
namespace Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base
{


 	/// <summary>
	/// I_Base_Navigation Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/User Defined/Base/_Base Navigation</para>	
	/// <para>ID: b651325b-cf69-4b30-916d-7a8e51ea3fc5</para>	
	/// </summary>
	[SitecoreType(TemplateId=I_Base_NavigationConstants.TemplateIdString, AutoMap = true )] //, Cachable = true
	public partial interface I_Base_Navigation : IGlassBase 
	{
								/// <summary>
					/// The ExcludeFromNavigation field.
					/// <para></para>
					/// <para>Field Type: Checkbox</para>		
					/// <para>Field ID: c7e1e333-3593-40ae-8a54-4317665e813c</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(I_Base_NavigationConstants.ExcludeFromNavigationFieldName)]
					bool ExcludeFromNavigation  {get; set;}
			
				}


	public static partial class I_Base_NavigationConstants{

			public const string TemplateIdString = "b651325b-cf69-4b30-916d-7a8e51ea3fc5";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "_Base Navigation";

					
			public static readonly ID ExcludeFromNavigationFieldId = new ID("c7e1e333-3593-40ae-8a54-4317665e813c");
			public const string ExcludeFromNavigationFieldName = "ExcludeFromNavigation";
			
			

	}

	
	/// <summary>
	/// _Base_Navigation
	/// <para></para>
	/// <para>Path: /sitecore/templates/User Defined/Base/_Base Navigation</para>	
	/// <para>ID: b651325b-cf69-4b30-916d-7a8e51ea3fc5</para>	
	/// </summary>
	[SitecoreType(TemplateId=I_Base_NavigationConstants.TemplateIdString, AutoMap = true)] //, Cachable = true
	public partial class _Base_Navigation  : GlassBase, I_Base_Navigation 
	{
	   
						/// <summary>
				/// The ExcludeFromNavigation field.
				/// <para></para>
				/// <para>Field Type: Checkbox</para>		
				/// <para>Field ID: c7e1e333-3593-40ae-8a54-4317665e813c</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(I_Base_NavigationConstants.ExcludeFromNavigationFieldName)]
				public virtual bool ExcludeFromNavigation  {get; set;}
					
			
	}
}
namespace Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base
{


 	/// <summary>
	/// I_Base_Heading_Decoration Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/User Defined/Base/_Base Heading Decoration</para>	
	/// <para>ID: ca3aea07-1534-4e4a-91fa-ed2ec2923a6c</para>	
	/// </summary>
	[SitecoreType(TemplateId=I_Base_Heading_DecorationConstants.TemplateIdString, AutoMap = true )] //, Cachable = true
	public partial interface I_Base_Heading_Decoration : IGlassBase 
	{
								/// <summary>
					/// The DecorationBanner field.
					/// <para></para>
					/// <para>Field Type: Image</para>		
					/// <para>Field ID: 34f8fde4-8e5e-46dd-8a3f-2e93b475742e</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(I_Base_Heading_DecorationConstants.DecorationBannerFieldName)]
					Image DecorationBanner  {get; set;}
			
				}


	public static partial class I_Base_Heading_DecorationConstants{

			public const string TemplateIdString = "ca3aea07-1534-4e4a-91fa-ed2ec2923a6c";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "_Base Heading Decoration";

					
			public static readonly ID DecorationBannerFieldId = new ID("34f8fde4-8e5e-46dd-8a3f-2e93b475742e");
			public const string DecorationBannerFieldName = "DecorationBanner";
			
			

	}

	
	/// <summary>
	/// _Base_Heading_Decoration
	/// <para></para>
	/// <para>Path: /sitecore/templates/User Defined/Base/_Base Heading Decoration</para>	
	/// <para>ID: ca3aea07-1534-4e4a-91fa-ed2ec2923a6c</para>	
	/// </summary>
	[SitecoreType(TemplateId=I_Base_Heading_DecorationConstants.TemplateIdString, AutoMap = true)] //, Cachable = true
	public partial class _Base_Heading_Decoration  : GlassBase, I_Base_Heading_Decoration 
	{
	   
						/// <summary>
				/// The DecorationBanner field.
				/// <para></para>
				/// <para>Field Type: Image</para>		
				/// <para>Field ID: 34f8fde4-8e5e-46dd-8a3f-2e93b475742e</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(I_Base_Heading_DecorationConstants.DecorationBannerFieldName)]
				public virtual Image DecorationBanner  {get; set;}
					
			
	}
}
namespace Books.Foundation.Orm.Models.sitecore.templates.Project.Page_Types
{


 	/// <summary>
	/// IHome_Page Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/Project/Page Types/Home Page</para>	
	/// <para>ID: e006e803-dd5c-46ab-aa6b-419a52b657be</para>	
	/// </summary>
	[SitecoreType(TemplateId=IHome_PageConstants.TemplateIdString, AutoMap = true )] //, Cachable = true
	public partial interface IHome_Page : IGlassBase , global::Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base.I_Base_Content, global::Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base.I_Base_Heading_Decoration, global::Books.Foundation.Orm.Models.sitecore.templates.User_Defined.Base.I_Base_Navigation
	{
				}


	public static partial class IHome_PageConstants{

			public const string TemplateIdString = "e006e803-dd5c-46ab-aa6b-419a52b657be";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Home Page";

					
			public static readonly ID ContentBodyFieldId = new ID("8af829a4-3a05-4df4-8028-9505c7fd3d65");
			public const string ContentBodyFieldName = "ContentBody";
			
					
			public static readonly ID DecorationBannerFieldId = new ID("34f8fde4-8e5e-46dd-8a3f-2e93b475742e");
			public const string DecorationBannerFieldName = "DecorationBanner";
			
					
			public static readonly ID ExcludeFromNavigationFieldId = new ID("c7e1e333-3593-40ae-8a54-4317665e813c");
			public const string ExcludeFromNavigationFieldName = "ExcludeFromNavigation";
			
			

	}

	
	/// <summary>
	/// Home_Page
	/// <para></para>
	/// <para>Path: /sitecore/templates/Project/Page Types/Home Page</para>	
	/// <para>ID: e006e803-dd5c-46ab-aa6b-419a52b657be</para>	
	/// </summary>
	[SitecoreType(TemplateId=IHome_PageConstants.TemplateIdString, AutoMap = true)] //, Cachable = true
	public partial class Home_Page  : GlassBase, IHome_Page 
	{
	   
						/// <summary>
				/// The ContentBody field.
				/// <para></para>
				/// <para>Field Type: Multi-Line Text</para>		
				/// <para>Field ID: 8af829a4-3a05-4df4-8028-9505c7fd3d65</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IHome_PageConstants.ContentBodyFieldName)]
				public virtual string ContentBody  {get; set;}
					
						/// <summary>
				/// The DecorationBanner field.
				/// <para></para>
				/// <para>Field Type: Image</para>		
				/// <para>Field ID: 34f8fde4-8e5e-46dd-8a3f-2e93b475742e</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IHome_PageConstants.DecorationBannerFieldName)]
				public virtual Image DecorationBanner  {get; set;}
					
						/// <summary>
				/// The ExcludeFromNavigation field.
				/// <para></para>
				/// <para>Field Type: Checkbox</para>		
				/// <para>Field ID: c7e1e333-3593-40ae-8a54-4317665e813c</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IHome_PageConstants.ExcludeFromNavigationFieldName)]
				public virtual bool ExcludeFromNavigation  {get; set;}
					
			
	}
}
namespace Books.Foundation.Orm.Models.sitecore.templates.Feature
{


 	/// <summary>
	/// IHero Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/Feature/Hero</para>	
	/// <para>ID: ec25469a-c6e0-49db-8d6e-f77e539afc9b</para>	
	/// </summary>
	[SitecoreType(TemplateId=IHeroConstants.TemplateIdString, AutoMap = true )] //, Cachable = true
	public partial interface IHero : IGlassBase 
	{
								/// <summary>
					/// The CtaLink field.
					/// <para></para>
					/// <para>Field Type: link</para>		
					/// <para>Field ID: 7ee6e762-03d2-4513-8154-b4cf2d69c29f</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(IHeroConstants.CtaLinkFieldName)]
					object /* UNKNOWN */ CtaLink  {get; set;}
			
								/// <summary>
					/// The HeroImage field.
					/// <para></para>
					/// <para>Field Type: Image</para>		
					/// <para>Field ID: 7e161bda-d870-4ace-b4b2-037cd02fcd85</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(IHeroConstants.HeroImageFieldName)]
					Image HeroImage  {get; set;}
			
								/// <summary>
					/// The Subtitle field.
					/// <para></para>
					/// <para>Field Type: Rich Text</para>		
					/// <para>Field ID: 4bcb3f23-8352-46e5-89cb-f61c0bdb6468</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(IHeroConstants.SubtitleFieldName)]
					string Subtitle  {get; set;}
			
								/// <summary>
					/// The Title field.
					/// <para></para>
					/// <para>Field Type: Single-Line Text</para>		
					/// <para>Field ID: 4ff555ee-ed76-4b1f-afe1-5394a57684fd</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(IHeroConstants.TitleFieldName)]
					string Title  {get; set;}
			
				}


	public static partial class IHeroConstants{

			public const string TemplateIdString = "ec25469a-c6e0-49db-8d6e-f77e539afc9b";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Hero";

					
			public static readonly ID CtaLinkFieldId = new ID("7ee6e762-03d2-4513-8154-b4cf2d69c29f");
			public const string CtaLinkFieldName = "CtaLink";
			
					
			public static readonly ID HeroImageFieldId = new ID("7e161bda-d870-4ace-b4b2-037cd02fcd85");
			public const string HeroImageFieldName = "HeroImage";
			
					
			public static readonly ID SubtitleFieldId = new ID("4bcb3f23-8352-46e5-89cb-f61c0bdb6468");
			public const string SubtitleFieldName = "Subtitle";
			
					
			public static readonly ID TitleFieldId = new ID("4ff555ee-ed76-4b1f-afe1-5394a57684fd");
			public const string TitleFieldName = "Title";
			
			

	}

	
	/// <summary>
	/// Hero
	/// <para></para>
	/// <para>Path: /sitecore/templates/Feature/Hero</para>	
	/// <para>ID: ec25469a-c6e0-49db-8d6e-f77e539afc9b</para>	
	/// </summary>
	[SitecoreType(TemplateId=IHeroConstants.TemplateIdString, AutoMap = true)] //, Cachable = true
	public partial class Hero  : GlassBase, IHero 
	{
	   
						/// <summary>
				/// The CtaLink field.
				/// <para></para>
				/// <para>Field Type: link</para>		
				/// <para>Field ID: 7ee6e762-03d2-4513-8154-b4cf2d69c29f</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IHeroConstants.CtaLinkFieldName)]
				public virtual object /* UNKNOWN */ CtaLink  {get; set;}
					
						/// <summary>
				/// The HeroImage field.
				/// <para></para>
				/// <para>Field Type: Image</para>		
				/// <para>Field ID: 7e161bda-d870-4ace-b4b2-037cd02fcd85</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IHeroConstants.HeroImageFieldName)]
				public virtual Image HeroImage  {get; set;}
					
						/// <summary>
				/// The Subtitle field.
				/// <para></para>
				/// <para>Field Type: Rich Text</para>		
				/// <para>Field ID: 4bcb3f23-8352-46e5-89cb-f61c0bdb6468</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IHeroConstants.SubtitleFieldName)]
				public virtual string Subtitle  {get; set;}
					
						/// <summary>
				/// The Title field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: 4ff555ee-ed76-4b1f-afe1-5394a57684fd</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IHeroConstants.TitleFieldName)]
				public virtual string Title  {get; set;}
					
			
	}
}
