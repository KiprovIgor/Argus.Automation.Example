﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:1.0.0.0
//      Reqnroll Generator Version:1.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Restorant.Checkout.Tests.Features
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "1.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class CheckoutServiceTestsFeature : object, Xunit.IClassFixture<CheckoutServiceTestsFeature.FixtureData>, Xunit.IAsyncLifetime
    {
        
        private static Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "CheckoutServiceTests.feature"
#line hidden
        
        public CheckoutServiceTestsFeature(CheckoutServiceTestsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
        }
        
        public static async System.Threading.Tasks.Task FeatureSetupAsync()
        {
            testRunner = Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(null, Reqnroll.xUnit.ReqnrollPlugin.XUnitParallelWorkerTracker.Instance.GetWorkerId());
            Reqnroll.FeatureInfo featureInfo = new Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Tests/Features", "CheckoutServiceTests", null, ProgrammingLanguage.CSharp, featureTags);
            await testRunner.OnFeatureStartAsync(featureInfo);
        }
        
        public static async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
            string testWorkerId = testRunner.TestWorkerId;
            await testRunner.OnFeatureEndAsync();
            testRunner = null;
            Reqnroll.xUnit.ReqnrollPlugin.XUnitParallelWorkerTracker.Instance.ReleaseWorker(testWorkerId);
        }
        
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
        }
        
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
        }
        
        public void ScenarioInitialize(Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        public virtual async System.Threading.Tasks.Task FeatureBackgroundAsync()
        {
#line 3
#line hidden
            Reqnroll.Table table1 = new Reqnroll.Table(new string[] {
                        "Starters",
                        "Mains",
                        "Drinks",
                        "Service Charge",
                        "Drinks Discount",
                        "Drinks Discount Time"});
            table1.AddRow(new string[] {
                        "£4.00",
                        "£7.00",
                        "£2.50",
                        "10%",
                        "30%",
                        "19:00 - 23:00"});
#line 4
 await testRunner.GivenAsync("Restaurant opens with menu by set cost", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        async System.Threading.Tasks.Task Xunit.IAsyncLifetime.InitializeAsync()
        {
            await this.TestInitializeAsync();
        }
        
        async System.Threading.Tasks.Task Xunit.IAsyncLifetime.DisposeAsync()
        {
            await this.TestTearDownAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Checkout Service - Standard Order - Check bill calculated correctly")]
        [Xunit.TraitAttribute("FeatureTitle", "CheckoutServiceTests")]
        [Xunit.TraitAttribute("Description", "Checkout Service - Standard Order - Check bill calculated correctly")]
        [Xunit.TraitAttribute("Category", "TEST-1")]
        [Xunit.TraitAttribute("Category", "checkout")]
        public async System.Threading.Tasks.Task CheckoutService_StandardOrder_CheckBillCalculatedCorrectly()
        {
            string[] tagsOfScenario = new string[] {
                    "TEST-1",
                    "checkout"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("Checkout Service - Standard Order - Check bill calculated correctly", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 9
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
await this.FeatureBackgroundAsync();
#line hidden
                Reqnroll.Table table2 = new Reqnroll.Table(new string[] {
                            "TableNumber",
                            "StartersCount",
                            "MainsCount",
                            "DrinksCount",
                            "OrderTime"});
                table2.AddRow(new string[] {
                            "1",
                            "4",
                            "4",
                            "4",
                            "16:00"});
#line 10
 await testRunner.WhenAsync("Clients make an order", ((string)(null)), table2, "When ");
#line hidden
#line 13
  await testRunner.AndAsync("Clients requested a bill", ((string)(null)), ((Reqnroll.Table)(null)), "* ");
#line hidden
#line 14
 await testRunner.ThenAsync("Clients assert bill amount equals to 56.10 pounds sterling", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Checkout Service - Extended Order - Check bill calculated correctly")]
        [Xunit.TraitAttribute("FeatureTitle", "CheckoutServiceTests")]
        [Xunit.TraitAttribute("Description", "Checkout Service - Extended Order - Check bill calculated correctly")]
        [Xunit.TraitAttribute("Category", "TEST-2")]
        [Xunit.TraitAttribute("Category", "checkout")]
        public async System.Threading.Tasks.Task CheckoutService_ExtendedOrder_CheckBillCalculatedCorrectly()
        {
            string[] tagsOfScenario = new string[] {
                    "TEST-2",
                    "checkout"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("Checkout Service - Extended Order - Check bill calculated correctly", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 17
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
await this.FeatureBackgroundAsync();
#line hidden
                Reqnroll.Table table3 = new Reqnroll.Table(new string[] {
                            "TableNumber",
                            "StartersCount",
                            "MainsCount",
                            "DrinksCount",
                            "OrderTime"});
                table3.AddRow(new string[] {
                            "1",
                            "1",
                            "2",
                            "2",
                            "18:59"});
#line 18
 await testRunner.WhenAsync("Clients make an order", ((string)(null)), table3, "When ");
#line hidden
#line 21
  await testRunner.AndAsync("Clients requested a bill", ((string)(null)), ((Reqnroll.Table)(null)), "* ");
#line hidden
#line 22
 await testRunner.ThenAsync("Clients assert bill amount equals to 23.65 pounds sterling", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
                Reqnroll.Table table4 = new Reqnroll.Table(new string[] {
                            "TableNumber",
                            "MainsCount",
                            "DrinksCount",
                            "OrderTime"});
                table4.AddRow(new string[] {
                            "1",
                            "2",
                            "2",
                            "20:00"});
#line 23
 await testRunner.WhenAsync("Clients extend an order", ((string)(null)), table4, "When ");
#line hidden
#line 26
  await testRunner.AndAsync("Clients requested a bill", ((string)(null)), ((Reqnroll.Table)(null)), "* ");
#line hidden
#line 27
 await testRunner.ThenAsync("Clients assert bill amount equals to 44.55 pounds sterling", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Checkout Service - Partially Canceled Order - Check bill calculated correctly")]
        [Xunit.TraitAttribute("FeatureTitle", "CheckoutServiceTests")]
        [Xunit.TraitAttribute("Description", "Checkout Service - Partially Canceled Order - Check bill calculated correctly")]
        [Xunit.TraitAttribute("Category", "TEST-3")]
        [Xunit.TraitAttribute("Category", "checkout")]
        public async System.Threading.Tasks.Task CheckoutService_PartiallyCanceledOrder_CheckBillCalculatedCorrectly()
        {
            string[] tagsOfScenario = new string[] {
                    "TEST-3",
                    "checkout"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("Checkout Service - Partially Canceled Order - Check bill calculated correctly", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 30
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
await this.FeatureBackgroundAsync();
#line hidden
                Reqnroll.Table table5 = new Reqnroll.Table(new string[] {
                            "TableNumber",
                            "StartersCount",
                            "MainsCount",
                            "DrinksCount",
                            "OrderTime"});
                table5.AddRow(new string[] {
                            "1",
                            "1",
                            "1",
                            "4",
                            "19:00"});
#line 31
 await testRunner.WhenAsync("Clients make an order", ((string)(null)), table5, "When ");
#line hidden
#line 34
  await testRunner.AndAsync("Clients requested a bill", ((string)(null)), ((Reqnroll.Table)(null)), "* ");
#line hidden
#line 35
 await testRunner.ThenAsync("Clients assert bill amount equals to 23.10 pounds sterling", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
                Reqnroll.Table table6 = new Reqnroll.Table(new string[] {
                            "TableNumber",
                            "DrinksCount",
                            "OrderTime"});
                table6.AddRow(new string[] {
                            "1",
                            "1",
                            "19:01"});
#line 36
 await testRunner.WhenAsync("Clients partially cancel an order", ((string)(null)), table6, "When ");
#line hidden
#line 39
  await testRunner.AndAsync("Clients requested a bill", ((string)(null)), ((Reqnroll.Table)(null)), "* ");
#line hidden
#line 40
 await testRunner.ThenAsync("Clients assert bill amount equals to 20.35 pounds sterling", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "1.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : object, Xunit.IAsyncLifetime
        {
            
            async System.Threading.Tasks.Task Xunit.IAsyncLifetime.InitializeAsync()
            {
                await CheckoutServiceTestsFeature.FeatureSetupAsync();
            }
            
            async System.Threading.Tasks.Task Xunit.IAsyncLifetime.DisposeAsync()
            {
                await CheckoutServiceTestsFeature.FeatureTearDownAsync();
            }
        }
    }
}
#pragma warning restore
#endregion
