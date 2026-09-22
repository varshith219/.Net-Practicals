<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs"
    Inherits="Practical4.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">

        <p>ONLINE EVENT REGISTRATION</p>

        <table style="width:100%;">

            <!-- Full Name -->
            <tr>
                <td>
                    <asp:Label
                        ID="Label1"
                        runat="server"
                        Text="Full Name">
                    </asp:Label>
                </td>

                <td>
                    <asp:TextBox
                        ID="TextBox1"
                        runat="server">
                    </asp:TextBox>
                </td>

                <td>
                    <asp:RequiredFieldValidator
                        ID="RequiredFieldValidator1"
                        runat="server"
                        ControlToValidate="TextBox1"
                        ErrorMessage="Enter Your Full Name"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </td>
            </tr>

            <!-- Email -->
            <tr>
                <td>
                    <asp:Label
                        ID="Label2"
                        runat="server"
                        Text="Email">
                    </asp:Label>
                </td>

                <td>
                    <asp:TextBox
                        ID="TextBox2"
                        runat="server">
                    </asp:TextBox>
                </td>

                <td>
                    <asp:RequiredFieldValidator
                        ID="RequiredFieldValidator2"
                        runat="server"
                        ControlToValidate="TextBox2"
                        ErrorMessage="Enter Valid Email"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>

                    <br />

                    <asp:RequiredFieldValidator
                        ID="RequiredFieldValidator5"
                        runat="server"
                        ControlToValidate="TextBox2"
                        ErrorMessage="Invalid Email"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </td>
            </tr>

            <!-- Mobile -->
            <tr>
                <td>
                    <asp:Label
                        ID="Label3"
                        runat="server"
                        Text="Mobile">
                    </asp:Label>
                </td>

                <td>
                    <asp:TextBox
                        ID="TextBox3"
                        runat="server">
                    </asp:TextBox>
                </td>

                <td>
                    <asp:RequiredFieldValidator
                        ID="RequiredFieldValidator3"
                        runat="server"
                        ControlToValidate="TextBox3"
                        ErrorMessage="Enter Mobile Number"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>

                    <br />

                    <asp:RequiredFieldValidator
                        ID="RequiredFieldValidator4"
                        runat="server"
                        ControlToValidate="TextBox3"
                        ErrorMessage="Enter 10 Digit Mobile Number"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </td>
            </tr>

            <!-- College -->
            <tr>
                <td>
                    <asp:Label
                        ID="Label8"
                        runat="server"
                        Text="College">
                    </asp:Label>
                </td>

                <td>
                    <asp:TextBox
                        ID="TextBox4"
                        runat="server">
                    </asp:TextBox>
                </td>

                <td>
                    <asp:RequiredFieldValidator
                        ID="RequiredFieldValidator6"
                        runat="server"
                        ControlToValidate="TextBox4"
                        ErrorMessage="Enter Your College Name"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </td>
            </tr>

            <!-- Department -->
            <tr>
                <td>
                    <asp:Label
                        ID="Label4"
                        runat="server"
                        Text="Department">
                    </asp:Label>
                </td>

                <td>
                    <asp:RadioButton
                        ID="RadioButton1"
                        runat="server"
                        GroupName="Department"
                        Text="computer" />

                    <br />

                    <asp:RadioButton
                        ID="RadioButton2"
                        runat="server"
                        GroupName="Department"
                        OnCheckedChanged="RadioButton2_CheckedChanged"
                        Text="IT" />

                    <br />

                    <asp:RadioButton
                        ID="RadioButton3"
                        runat="server"
                        GroupName="Department"
                        Text="Mechanical" />

                    <br />

                    <asp:RadioButton
                        ID="RadioButton4"
                        runat="server"
                        GroupName="Department"
                        Text="Civil" />
                </td>

                <td>
                    &nbsp;
                </td>
            </tr>

            <!-- Event -->
            <tr>
                <td>
                    <asp:Label
                        ID="Label6"
                        runat="server"
                        Text="Event">
                    </asp:Label>
                </td>

                <td>
                    <asp:DropDownList
                        ID="DropDownList1"
                        runat="server"
                        Height="34px"
                        OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
                        Width="157px">

                        <asp:ListItem>
                            Hackathon
                        </asp:ListItem>

                        <asp:ListItem>
                            Biothon
                        </asp:ListItem>

                    </asp:DropDownList>
                </td>

                <td>
                    &nbsp;
                </td>
            </tr>

            <!-- Gender -->
            <tr>
                <td>
                    <asp:Label
                        ID="Label7"
                        runat="server"
                        Text="Gender">
                    </asp:Label>
                </td>

                <td>
                    <asp:RadioButton
                        ID="RadioButton5"
                        runat="server"
                        GroupName="Gender"
                        Text="Male" />

                    <br />

                    <asp:RadioButton
                        ID="RadioButton6"
                        runat="server"
                        GroupName="Gender"
                        Text="Female" />
                </td>

                <td>
                </td>
            </tr>

            <!-- Skills -->
            <tr>
                <td>
                    <asp:Label
                        ID="Label5"
                        runat="server"
                        Text="Skills">
                    </asp:Label>
                </td>

                <td>
                    <asp:CheckBox
                        ID="CheckBox1"
                        runat="server"
                        Text="C#" />

                    <br />

                    <asp:CheckBox
                        ID="CheckBox2"
                        runat="server"
                        Text="Java" />

                    <br />

                    <asp:CheckBox
                        ID="CheckBox3"
                        runat="server"
                        Text="Python" />

                    <br />

                    <asp:CheckBox
                        ID="CheckBox4"
                        runat="server"
                        Text="C" />
                </td>

                <td>
                </td>
            </tr>

            <!-- Address -->
            <tr>
                <td>
                    <asp:Label
                        ID="Label9"
                        runat="server"
                        Text="Address">
                    </asp:Label>
                </td>

                <td>
                    <textarea
                        id="TextArea1"
                        class="auto-style4"
                        name="S1">
                    </textarea>
                </td>

                <td>
                    &nbsp;
                </td>
            </tr>

            <!-- Terms -->
            <tr>
                <td>
                    <asp:Label
                        ID="Label10"
                        runat="server"
                        Text="Terms">
                    </asp:Label>
                </td>

                <td>
                    <asp:CheckBox
                        ID="CheckBox5"
                        runat="server"
                        Text="I Accept Trems &amp; Conditions" />
                </td>

                <td>
                    &nbsp;
                </td>
            </tr>

            <!-- Register Button -->
            <tr>
                <td>
                    <asp:Button
                        ID="Button1"
                        runat="server"
                        Text="Register"
                        OnClick="Button1_Click" />
                </td>

                <td>
                    &nbsp;
                </td>

                <td>
                    &nbsp;
                </td>
            </tr>

        </table>

    </form>
</body>
</html>

registration.aspx.cs

using System;
using System.Web.UI;

namespace Practical4
{
    public partial class registration : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        }
    }
}
