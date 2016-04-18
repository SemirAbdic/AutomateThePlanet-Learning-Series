// <copyright file="TestRunUnitTest.cs" company="Automate The Planet Ltd.">
// Copyright 2016 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Anton Angelov</author>
// <site>http://automatetheplanet.com/</site>
using System.Xml.Serialization;

namespace MSTest.Console.Extended.Data
{
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunUnitTest
    {
        private TestRunUnitTestExecution executionField;

        private TestRunUnitTestTestMethod testMethodField;

        private TestRunUnitTestOwners ownersField;

        private TestRunUnitTestTestCategory testCategoryField;

        private string nameField;

        private string storageField;

        private string idField;

        /// <remarks/>
        public TestRunUnitTestOwners Owners
        {
            get
            {
                return this.ownersField;
            }
            set
            {
                this.ownersField = value;
            }
        }

        /// <remarks/>
        public TestRunUnitTestTestCategory TestCategory
        {
            get
            {
                return this.testCategoryField;
            }
            set
            {
                this.testCategoryField = value;
            }
        }

        /// <remarks/>
        public TestRunUnitTestExecution Execution
        {
            get
            {
                return this.executionField;
            }
            set
            {
                this.executionField = value;
            }
        }

        /// <remarks/>
        public TestRunUnitTestTestMethod TestMethod
        {
            get
            {
                return this.testMethodField;
            }
            set
            {
                this.testMethodField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute]
        public string storage
        {
            get
            {
                return this.storageField;
            }
            set
            {
                this.storageField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
}