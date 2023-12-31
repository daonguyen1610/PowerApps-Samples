﻿/*
 * Copyright (c) Microsoft Corporation.
 * Licensed under the MIT license.
 * Auto generated by Crmsvcutil.
 * Ref form SDK samples: https://github.com/microsoft/PowerApps-Samples/blob/master/dataverse/orgsvc/C%23/MyOrganizationSdkTypes.cs
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.PowerPlatform.Administration.Helpers
{
    public partial class SystemUserRoles : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SystemUserRoles() :
                base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "systemuserroles";

        public const int EntityTypeCode = 15;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        private void OnPropertyChanged(string propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        private void OnPropertyChanging(string propertyName)
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
            }
        }

        /// <summary>
        /// For internal use only
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roleid")]
        public System.Nullable<System.Guid> RoleId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("roleid");
            }
        }

        /// <summary>
        /// For internal use only
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
        public System.Nullable<System.Guid> SystemUserId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("systemuserid");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserroleid")]
        public System.Nullable<System.Guid> SystemUserRoleId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("systemuserroleid");
            }
            set
            {
                this.OnPropertyChanging("SystemUserRoleId");
                this.SetAttributeValue("systemuserroleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SystemUserRoleId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserroleid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.SystemUserRoleId = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
            }
        }

        /// <summary>
        /// N:N systemuserroles_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuserroles_association")]
        public System.Collections.Generic.IEnumerable<SystemUser> systemuserroles_association
        {
            get
            {
                return this.GetRelatedEntities<SystemUser>("systemuserroles_association", null);
            }
            set
            {
                this.OnPropertyChanging("systemuserroles_association");
                this.SetRelatedEntities<SystemUser>("systemuserroles_association", null, value);
                this.OnPropertyChanged("systemuserroles_association");
            }
        }
    }

    /// <summary>
    /// Person with access to the Microsoft CRM system and who owns objects in the Microsoft CRM database.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("systemuser")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0001.0117")]
    public partial class SystemUser : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SystemUser() :
                base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "systemuser";

        public const int EntityTypeCode = 8;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        private void OnPropertyChanged(string propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        private void OnPropertyChanging(string propertyName)
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Type of user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accessmode")]
        public Microsoft.Xrm.Sdk.OptionSetValue AccessMode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accessmode");
            }
            set
            {
                this.OnPropertyChanging("AccessMode");
                this.SetAttributeValue("accessmode", value);
                this.OnPropertyChanged("AccessMode");
            }
        }

        /// <summary>
        /// Information about whether the user is licensed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("islicensed")]
        public System.Nullable<bool> IsLicensed
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("islicensed");
            }
            set
            {
                this.OnPropertyChanging("IsLicensed");
                this.SetAttributeValue("islicensed", value);
                this.OnPropertyChanged("IsLicensed");
            }
        }

        /// <summary>
        /// Active Directory domain of which the user is a member.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("domainname")]
        public string DomainName
        {
            get
            {
                return this.GetAttributeValue<string>("domainname");
            }
            set
            {
                this.OnPropertyChanging("DomainName");
                this.SetAttributeValue("domainname", value);
                this.OnPropertyChanged("DomainName");
            }
        }

        /// <summary>
        /// Unique identifier for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
        public System.Nullable<System.Guid> SystemUserId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("systemuserid");
            }
            set
            {
                this.OnPropertyChanging("SystemUserId");
                this.SetAttributeValue("systemuserid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SystemUserId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.SystemUserId = value;
            }
        }


    }


    /// <summary>
    /// Grouping of security privileges. Users are assigned roles that authorize their access to the Microsoft CRM system.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("role")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0001.0117")]
    public partial class Role : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Role() :
                base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "role";

        public const int EntityTypeCode = 1036;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        private void OnPropertyChanged(string propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        private void OnPropertyChanging(string propertyName)
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Unique identifier of the business unit with which the role is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        public Microsoft.Xrm.Sdk.EntityReference BusinessUnitId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businessunitid");
            }
            set
            {
                this.OnPropertyChanging("BusinessUnitId");
                this.SetAttributeValue("businessunitid", value);
                this.OnPropertyChanged("BusinessUnitId");
            }
        }

        /// <summary>
        /// Name of the role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
        public string Name
        {
            get
            {
                return this.GetAttributeValue<string>("name");
            }
            set
            {
                this.OnPropertyChanging("Name");
                this.SetAttributeValue("name", value);
                this.OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public System.Nullable<System.Guid> OrganizationId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid");
            }
        }

        /// <summary>
        /// Unique identifier of the parent role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentroleid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentRoleId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentroleid");
            }
        }

        /// <summary>
        /// Unique identifier of the parent root role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentrootroleid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentRootRoleId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentrootroleid");
            }
        }

        /// <summary>
        /// Unique identifier of the role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roleid")]
        public System.Nullable<System.Guid> RoleId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("roleid");
            }
            set
            {
                this.OnPropertyChanging("RoleId");
                this.SetAttributeValue("roleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("RoleId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roleid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.RoleId = value;
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roleidunique")]
        public System.Nullable<System.Guid> RoleIdUnique
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("roleidunique");
            }
        }

        /// <summary>
        /// Unique identifier of the role template that is associated with the role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roletemplateid")]
        public Microsoft.Xrm.Sdk.EntityReference RoleTemplateId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("roletemplateid");
            }
        }


        /// <summary>
        /// N:N  systemuserroles_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuserroles_association")]
        public System.Collections.Generic.IEnumerable<SystemUser> systemuserroles_association
        {
            get
            {
                return this.GetRelatedEntities<SystemUser>("systemuserroles_association", null);
            }
            set
            {
                this.OnPropertyChanging("systemuserroles_association");
                this.SetRelatedEntities<SystemUser>("systemuserroles_association", null, value);
                this.OnPropertyChanged("systemuserroles_association");
            }
        }

    }

    public enum AccessMode
    {
        ReadWrite,
        Administrative,
        Read,
        SupportUser,
        Noninteractive,
        DelegatedAdmin
    }
}
