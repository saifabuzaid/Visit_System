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

namespace visit_system
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="visiting")]
	public partial class vistDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDoctor(Doctor instance);
    partial void UpdateDoctor(Doctor instance);
    partial void DeleteDoctor(Doctor instance);
    partial void Insertpatient(patient instance);
    partial void Updatepatient(patient instance);
    partial void Deletepatient(patient instance);
    partial void Insertvisite(visite instance);
    partial void Updatevisite(visite instance);
    partial void Deletevisite(visite instance);
    #endregion
		
		public vistDataContext() : 
				base(global::visit_system.Properties.Settings.Default.visitingConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public vistDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public vistDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public vistDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public vistDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Doctor> Doctors
		{
			get
			{
				return this.GetTable<Doctor>();
			}
		}
		
		public System.Data.Linq.Table<patient> patients
		{
			get
			{
				return this.GetTable<patient>();
			}
		}
		
		public System.Data.Linq.Table<visite> visites
		{
			get
			{
				return this.GetTable<visite>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Doctor")]
	public partial class Doctor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DoctorNo;
		
		private string _DoctorName;
		
		private long _phone;
		
		private double _salary;
		
		private EntitySet<visite> _visites;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDoctorNoChanging(int value);
    partial void OnDoctorNoChanged();
    partial void OnDoctorNameChanging(string value);
    partial void OnDoctorNameChanged();
    partial void OnphoneChanging(long value);
    partial void OnphoneChanged();
    partial void OnsalaryChanging(double value);
    partial void OnsalaryChanged();
    #endregion
		
		public Doctor()
		{
			this._visites = new EntitySet<visite>(new Action<visite>(this.attach_visites), new Action<visite>(this.detach_visites));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorNo", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int DoctorNo
		{
			get
			{
				return this._DoctorNo;
			}
			set
			{
				if ((this._DoctorNo != value))
				{
					this.OnDoctorNoChanging(value);
					this.SendPropertyChanging();
					this._DoctorNo = value;
					this.SendPropertyChanged("DoctorNo");
					this.OnDoctorNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DoctorName
		{
			get
			{
				return this._DoctorName;
			}
			set
			{
				if ((this._DoctorName != value))
				{
					this.OnDoctorNameChanging(value);
					this.SendPropertyChanging();
					this._DoctorName = value;
					this.SendPropertyChanged("DoctorName");
					this.OnDoctorNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="BigInt NOT NULL")]
		public long phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_salary", DbType="Float NOT NULL")]
		public double salary
		{
			get
			{
				return this._salary;
			}
			set
			{
				if ((this._salary != value))
				{
					this.OnsalaryChanging(value);
					this.SendPropertyChanging();
					this._salary = value;
					this.SendPropertyChanged("salary");
					this.OnsalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Doctor_visite", Storage="_visites", ThisKey="DoctorNo", OtherKey="DoctorNo")]
		public EntitySet<visite> visites
		{
			get
			{
				return this._visites;
			}
			set
			{
				this._visites.Assign(value);
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
		
		private void attach_visites(visite entity)
		{
			this.SendPropertyChanging();
			entity.Doctor = this;
		}
		
		private void detach_visites(visite entity)
		{
			this.SendPropertyChanging();
			entity.Doctor = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.patient")]
	public partial class patient : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PatientNo;
		
		private string _patientName;
		
		private string _Gender;
		
		private System.DateTime _DateBrth;
		
		private long _phone;
		
		private EntitySet<visite> _visites;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPatientNoChanging(int value);
    partial void OnPatientNoChanged();
    partial void OnpatientNameChanging(string value);
    partial void OnpatientNameChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnDateBrthChanging(System.DateTime value);
    partial void OnDateBrthChanged();
    partial void OnphoneChanging(long value);
    partial void OnphoneChanged();
    #endregion
		
		public patient()
		{
			this._visites = new EntitySet<visite>(new Action<visite>(this.attach_visites), new Action<visite>(this.detach_visites));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PatientNo", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PatientNo
		{
			get
			{
				return this._PatientNo;
			}
			set
			{
				if ((this._PatientNo != value))
				{
					this.OnPatientNoChanging(value);
					this.SendPropertyChanging();
					this._PatientNo = value;
					this.SendPropertyChanged("PatientNo");
					this.OnPatientNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_patientName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string patientName
		{
			get
			{
				return this._patientName;
			}
			set
			{
				if ((this._patientName != value))
				{
					this.OnpatientNameChanging(value);
					this.SendPropertyChanging();
					this._patientName = value;
					this.SendPropertyChanged("patientName");
					this.OnpatientNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(1) NOT NULL", CanBeNull=false)]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateBrth", DbType="Date NOT NULL")]
		public System.DateTime DateBrth
		{
			get
			{
				return this._DateBrth;
			}
			set
			{
				if ((this._DateBrth != value))
				{
					this.OnDateBrthChanging(value);
					this.SendPropertyChanging();
					this._DateBrth = value;
					this.SendPropertyChanged("DateBrth");
					this.OnDateBrthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="BigInt NOT NULL")]
		public long phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="patient_visite", Storage="_visites", ThisKey="PatientNo", OtherKey="patientno")]
		public EntitySet<visite> visites
		{
			get
			{
				return this._visites;
			}
			set
			{
				this._visites.Assign(value);
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
		
		private void attach_visites(visite entity)
		{
			this.SendPropertyChanging();
			entity.patient = this;
		}
		
		private void detach_visites(visite entity)
		{
			this.SendPropertyChanging();
			entity.patient = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.visite")]
	public partial class visite : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DoctorNo;
		
		private int _patientno;
		
		private EntityRef<Doctor> _Doctor;
		
		private EntityRef<patient> _patient;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDoctorNoChanging(int value);
    partial void OnDoctorNoChanged();
    partial void OnpatientnoChanging(int value);
    partial void OnpatientnoChanged();
    #endregion
		
		public visite()
		{
			this._Doctor = default(EntityRef<Doctor>);
			this._patient = default(EntityRef<patient>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorNo", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int DoctorNo
		{
			get
			{
				return this._DoctorNo;
			}
			set
			{
				if ((this._DoctorNo != value))
				{
					if (this._Doctor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDoctorNoChanging(value);
					this.SendPropertyChanging();
					this._DoctorNo = value;
					this.SendPropertyChanged("DoctorNo");
					this.OnDoctorNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_patientno", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int patientno
		{
			get
			{
				return this._patientno;
			}
			set
			{
				if ((this._patientno != value))
				{
					if (this._patient.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnpatientnoChanging(value);
					this.SendPropertyChanging();
					this._patientno = value;
					this.SendPropertyChanged("patientno");
					this.OnpatientnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Doctor_visite", Storage="_Doctor", ThisKey="DoctorNo", OtherKey="DoctorNo", IsForeignKey=true)]
		public Doctor Doctor
		{
			get
			{
				return this._Doctor.Entity;
			}
			set
			{
				Doctor previousValue = this._Doctor.Entity;
				if (((previousValue != value) 
							|| (this._Doctor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Doctor.Entity = null;
						previousValue.visites.Remove(this);
					}
					this._Doctor.Entity = value;
					if ((value != null))
					{
						value.visites.Add(this);
						this._DoctorNo = value.DoctorNo;
					}
					else
					{
						this._DoctorNo = default(int);
					}
					this.SendPropertyChanged("Doctor");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="patient_visite", Storage="_patient", ThisKey="patientno", OtherKey="PatientNo", IsForeignKey=true)]
		public patient patient
		{
			get
			{
				return this._patient.Entity;
			}
			set
			{
				patient previousValue = this._patient.Entity;
				if (((previousValue != value) 
							|| (this._patient.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._patient.Entity = null;
						previousValue.visites.Remove(this);
					}
					this._patient.Entity = value;
					if ((value != null))
					{
						value.visites.Add(this);
						this._patientno = value.PatientNo;
					}
					else
					{
						this._patientno = default(int);
					}
					this.SendPropertyChanged("patient");
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
