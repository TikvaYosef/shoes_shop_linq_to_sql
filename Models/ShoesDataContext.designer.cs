﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace shoes_shop_linq_to_sql.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ShoesDataBase")]
	public partial class ShoesDataContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKidsShoe(KidsShoe instance);
    partial void UpdateKidsShoe(KidsShoe instance);
    partial void DeleteKidsShoe(KidsShoe instance);
    #endregion
		
		public ShoesDataContextDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ShoesDataBaseConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ShoesDataContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ShoesDataContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ShoesDataContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ShoesDataContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<KidsShoe> KidsShoes
		{
			get
			{
				return this.GetTable<KidsShoe>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KidsShoes")]
	public partial class KidsShoe : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _company;
		
		private string _material;
		
		private System.Nullable<bool> _Instock;
		
		private System.Nullable<int> _size;
		
		private System.Nullable<int> _price;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OncompanyChanging(string value);
    partial void OncompanyChanged();
    partial void OnmaterialChanging(string value);
    partial void OnmaterialChanged();
    partial void OnInstockChanging(System.Nullable<bool> value);
    partial void OnInstockChanged();
    partial void OnsizeChanging(System.Nullable<int> value);
    partial void OnsizeChanged();
    partial void OnpriceChanging(System.Nullable<int> value);
    partial void OnpriceChanged();
    #endregion
		
		public KidsShoe()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_company", DbType="VarChar(20)")]
		public string company
		{
			get
			{
				return this._company;
			}
			set
			{
				if ((this._company != value))
				{
					this.OncompanyChanging(value);
					this.SendPropertyChanging();
					this._company = value;
					this.SendPropertyChanged("company");
					this.OncompanyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_material", DbType="VarChar(20)")]
		public string material
		{
			get
			{
				return this._material;
			}
			set
			{
				if ((this._material != value))
				{
					this.OnmaterialChanging(value);
					this.SendPropertyChanging();
					this._material = value;
					this.SendPropertyChanged("material");
					this.OnmaterialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Instock", DbType="Bit")]
		public System.Nullable<bool> Instock
		{
			get
			{
				return this._Instock;
			}
			set
			{
				if ((this._Instock != value))
				{
					this.OnInstockChanging(value);
					this.SendPropertyChanging();
					this._Instock = value;
					this.SendPropertyChanged("Instock");
					this.OnInstockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_size", DbType="Int")]
		public System.Nullable<int> size
		{
			get
			{
				return this._size;
			}
			set
			{
				if ((this._size != value))
				{
					this.OnsizeChanging(value);
					this.SendPropertyChanging();
					this._size = value;
					this.SendPropertyChanged("size");
					this.OnsizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Int")]
		public System.Nullable<int> price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591