using SitefinityWebApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telerik.Sitefinity.DynamicModules;
using Telerik.Sitefinity.DynamicModules.Model;
using Telerik.Sitefinity.Forms.Model;
using Telerik.Sitefinity.GenericContent.Model;
using Telerik.Sitefinity.Model;
using Telerik.Sitefinity.Modules.Forms;
using Telerik.Sitefinity.RelatedData;
using Telerik.Sitefinity.Security;
using Telerik.Sitefinity.Utilities.TypeConverters;

namespace SitefinityWebApp.Library
{
    public partial class SFProcess
    {
        public List<FormModel> GetProductForm()
        {
            try
            {
                DynamicModuleManager dynamicModuleManager = DynamicModuleManager.GetManager(providerName);
                dynamicModuleManager.Provider.SuppressSecurityChecks = true;
                Type generalnoticeType = TypeResolutionService.ResolveType("Telerik.Sitefinity.DynamicTypes.Model.FormModule.ProductFormModule");
                var myFilteredCollection = dynamicModuleManager.GetDataItems(generalnoticeType);
                List<DynamicContent> contents = myFilteredCollection.ToList().Where(item => item.ApprovalWorkflowState.Value == "Published" && item.Status == ContentLifecycleStatus.Master && (bool)item.GetValue("IsActive")).ToList();

                List<FormModel> formModels = new List<FormModel>();
                List<FormModelDropDown> formModelDropDowns;
                FormModel formModel;
                FormModelDropDown formModelDropDown;
                if (contents != null && contents.Count > 0)
                {
                    contents.ForEach(cItem =>
                    {
                        formModel = new FormModel()
                        {
                            InputName = (Lstring)(cItem.GetValue("InputName")),
                            InputClass = (Lstring)(cItem.GetValue("InputClass")),
                            InputNotVisible = cItem.GetValue("InputNotVisible") != null ? (bool)cItem.GetValue("InputNotVisible") : false,
                            InputValue = (Lstring)(cItem.GetValue("InputValue")),
                            LabelValue = (Lstring)(cItem.GetValue("LabelValue")),
                            LabelValueShort = (Lstring)(cItem.GetValue("LabelValueShort")),
                            //IsRequired= cItem.GetValue("IsRequired") != null ? (bool)cItem.GetValue("IsRequired") : false,
                            Order = cItem.GetValue("Order") != null ? int.Parse(cItem.GetValue("Order").ToString()) : 1000,
                            InputType = (InputType)int.Parse(((ChoiceOption)(cItem.GetValue("InputType"))).PersistedValue),                            
                        };

                        
                        List<IDataItem> videoItems = cItem.GetRelatedItems("FormDropDownList").ToList();
                        formModelDropDowns = new List<FormModelDropDown>();
                        if (videoItems.Count > 0)
                        {
                            videoItems.ForEach(ct =>
                            {
                                DynamicContent videoContent = (DynamicContent)ct;
                                if (videoContent != null)
                                {
                                    formModelDropDown = new FormModelDropDown()
                                    {
                                        Text = (Lstring)(videoContent.GetValue("DropDownText")),
                                        Value = (Lstring)(videoContent.GetValue("DropDownValue")),
                                        FieldValue = (Lstring)(videoContent.GetValue("OptionFieldValue")),
                                        
                                    };
                                    formModelDropDowns.Add(formModelDropDown);
                                }
                            });
                            formModel.DropDownItem = formModelDropDowns;
                        }
                        formModels.Add(formModel);
                    });
                    
                }
                return formModels.OrderBy(x => x.Order).ToList(); ;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void GetForm(Guid formId, string newTitle)
        {
            try
            {
                var formManager = FormsManager.GetManager();
                var form = formManager.GetForms().Where(f => f.Id == formId).SingleOrDefault();

                if (form != null)
                {
                    form.Title = newTitle;

                    var draft = formManager.EditForm(form.Id);
                    var master = formManager.Lifecycle.CheckOut(draft);

                    if (master != null)
                    {
                        master = formManager.Lifecycle.CheckIn(master);
                        formManager.Lifecycle.Publish(master);
                        formManager.SaveChanges();
                    }
                }
            
                
            }
            catch (Exception ex)
            {
                
            }
        }

        public void GetFormFieldValuesFromFormResponses(string formName, string formFieldName)
        {
            FormsManager formsManager = FormsManager.GetManager();
            
            var forms = formsManager.GetForms().Where(f => f.Name == formName);
            
            foreach (var form in forms)
            {
                var records = formsManager.GetFormEntries(form);
                foreach (var record in records)
                {
                    FormEntry fe = (FormEntry)record;
                    var Value1 = fe.GetValue("formdropdownlist1");
                }
            }
        }


        public bool SaveProductWizardForm(ProductWizardFormModel model)
        {
            bool retVal = false;
            try
            {
                DynamicModuleManager dynamicModuleManager = DynamicModuleManager.GetManager(providerName);
                dynamicModuleManager.Provider.SuppressSecurityChecks = true;
                Type productWizardFormType = TypeResolutionService.ResolveType("Telerik.Sitefinity.DynamicTypes.Model.Products.ProductWizardForm");
                string guid = Guid.NewGuid().ToString();
                DateTime now = DateTime.Now;

                DynamicContent formItem = dynamicModuleManager.CreateDataItem(productWizardFormType);        
                formItem.SetValue("Title", string.Format("{0} {1} - {2}", model.FirstName, model.LastName, now.ToString()));
                formItem.UrlName = guid;
                formItem.SetValue("FirstName", model.FirstName);
                formItem.SetValue("LastName", model.LastName);
                formItem.SetValue("Email", model.Email);
                formItem.SetValue("Phone", model.Phone);
                formItem.SetValue("CompanyName", model.Company);
                formItem.SetValue("FoundationYear", model.FoundationYear);
                formItem.SetValue("Sector", model.Sector);
                formItem.SetValue("IPAddress", model.IPAddress);
                formItem.SetValue("NumberOfEmployees", model.NumberOfEmployees);
                formItem.SetValue("CurrentSituation", model.CurrentSituation);
                formItem.SetValue("NumberOfUser", model.NumberOfUser);
                formItem.SetValue("Gclid", model.GClid);
                formItem.SetValue("UtmCampaign", model.UtmCampaign);
                formItem.SetValue("UtmMedium", model.UtmMedium);
                formItem.SetValue("UtmSource", model.UtmSource);
                formItem.SetValue("CurrentSoftware", model.CurrentSoftware);
                formItem.SetValue("Owner", SecurityManager.GetCurrentUserId());
                formItem.SetValue("PublicationDate", DateTime.Now);
                dynamicModuleManager.Lifecycle.Publish(formItem);
                formItem.ApprovalWorkflowState = "Published";
                dynamicModuleManager.SaveChanges();   
            }
            catch (Exception)
            { }

            return retVal;
        }

        public bool SaveDemoRequestForm(DemoRequestFormModel model)
        {
            bool retVal = false;
            try
            {
                DynamicModuleManager dynamicModuleManager = DynamicModuleManager.GetManager(providerName);
                dynamicModuleManager.Provider.SuppressSecurityChecks = true;
                Type demoRequestFormType = TypeResolutionService.ResolveType("Telerik.Sitefinity.DynamicTypes.Model.Products.DemoRequestForm");
                string guid = Guid.NewGuid().ToString();
                DateTime now = DateTime.Now;

                DynamicContent formItem = dynamicModuleManager.CreateDataItem(demoRequestFormType);
                formItem.SetValue("Title", string.Format("{0} {1} - {2}", model.FirstName, model.LastName, now.ToString()));
                formItem.UrlName = guid;
                formItem.SetValue("FirstName", model.FirstName);
                formItem.SetValue("LastName", model.LastName);
                formItem.SetValue("Email", model.Email);
                formItem.SetValue("Phone", model.Phone);
                formItem.SetValue("City", model.City);
                formItem.SetValue("ProductGroup", model.ProductGroup);
                formItem.SetValue("Gclid", model.GClid);
                formItem.SetValue("UtmCampaign", model.UtmCampaign);
                formItem.SetValue("UtmMedium", model.UtmMedium);
                formItem.SetValue("UtmSource", model.UtmSource);
                formItem.SetValue("Message", model.Message);
                formItem.SetValue("IPAddress", model.IPAddress);            
                formItem.SetValue("Owner", SecurityManager.GetCurrentUserId());
                formItem.SetValue("PublicationDate", DateTime.Now);
                dynamicModuleManager.Lifecycle.Publish(formItem);
                formItem.ApprovalWorkflowState = "Published";
                dynamicModuleManager.SaveChanges();
            }
            catch (Exception)
            { }

            return retVal;
        }

        public bool SaveContactForm(ContactFormModel model)
        {
            bool retVal = false;
            try
            {
                DynamicModuleManager dynamicModuleManager = DynamicModuleManager.GetManager(providerName);
                dynamicModuleManager.Provider.SuppressSecurityChecks = true;
                Type demoRequestFormType = TypeResolutionService.ResolveType("Telerik.Sitefinity.DynamicTypes.Model.Contact.ContactForm");
                string guid = Guid.NewGuid().ToString();
                DateTime now = DateTime.Now;

                DynamicContent formItem = dynamicModuleManager.CreateDataItem(demoRequestFormType);
                formItem.SetValue("Title", string.Format("{0} {1} - {2}", model.FirstName, model.LastName, now.ToString()));
                formItem.UrlName = guid;
                formItem.SetValue("FirstName", model.FirstName);
                formItem.SetValue("LastName", model.LastName);
                formItem.SetValue("Email", model.Email);
                formItem.SetValue("Phone", model.Phone);                     
                formItem.SetValue("CompanyName", model.Company);                  
                formItem.SetValue("Gclid", model.GClid);
                formItem.SetValue("UtmCampaign", model.UtmCampaign);
                formItem.SetValue("UtmMedium", model.UtmMedium);
                formItem.SetValue("UtmSource", model.UtmSource);
                formItem.SetValue("Subject", model.Subject);
                formItem.SetValue("Message", model.Message);
                formItem.SetValue("IPAddress", model.IPAddress);
                formItem.SetValue("Owner", SecurityManager.GetCurrentUserId());
                formItem.SetValue("PublicationDate", DateTime.Now);
                dynamicModuleManager.Lifecycle.Publish(formItem);
                formItem.ApprovalWorkflowState = "Published";
                dynamicModuleManager.SaveChanges();
            }
            catch (Exception)
            { }

            return retVal;
        }
    }
}