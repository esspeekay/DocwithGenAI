using UiPath.CodedWorkflows;
using System;

namespace DUProcesswithGenAI
{
    public class GoogleDocsFactory
    {
        public GoogleDocsFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }

    public class DriveFactory
    {
        public DriveFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }

    public class GmailFactory
    {
        public UiPath.GSuite.Activities.Api.GmailConnection My_Workspace_praveensenthil1999_gmail_com__2 { get; set; }
        public UiPath.GSuite.Activities.Api.GmailConnection My_Workspace_praveensenthil1999_gmail_com__3 { get; set; }

        public GmailFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_praveensenthil1999_gmail_com__2 = new UiPath.GSuite.Activities.Api.GmailConnection("dd1bc865-ca40-4ce0-8ec5-829f0d54c8f2", resolver);
            My_Workspace_praveensenthil1999_gmail_com__3 = new UiPath.GSuite.Activities.Api.GmailConnection("c2b30f96-fa4a-41c6-b2f2-6a1c49427a54", resolver);
        }
    }

    public class GoogleSheetsFactory
    {
        public GoogleSheetsFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }
}