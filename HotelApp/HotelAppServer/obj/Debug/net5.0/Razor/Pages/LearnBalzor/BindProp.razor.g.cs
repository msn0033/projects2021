#pragma checksum "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "628af94db324daf5fd066bfffd551c7849e4e1ad"
// <auto-generated/>
#pragma warning disable 1591
namespace HotelAppServer.Pages.LearnBalzor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\PROJECT\HotelApp\HotelAppServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROJECT\HotelApp\HotelAppServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\PROJECT\HotelApp\HotelAppServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\PROJECT\HotelApp\HotelAppServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\PROJECT\HotelApp\HotelAppServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\PROJECT\HotelApp\HotelAppServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\PROJECT\HotelApp\HotelAppServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\PROJECT\HotelApp\HotelAppServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\PROJECT\HotelApp\HotelAppServer\_Imports.razor"
using HotelAppServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\PROJECT\HotelApp\HotelAppServer\_Imports.razor"
using HotelAppServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\PROJECT\HotelApp\HotelAppServer\_Imports.razor"
using HotelAppServer.Pages.LearnBalzor.LearnComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
using Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bindprop")]
    public partial class BindProp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-light border p-2");
            __builder.OpenElement(2, "h2");
            __builder.AddAttribute(3, "class", "bg-light border p-2");
            __builder.AddMarkupContent(4, "\r\n\r\n        RoomName = ");
            __builder.AddContent(5, 
#nullable restore
#line 10 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
                    om.RoomName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(6, "\r\n        <br>\r\n        price = ");
            __builder.AddContent(7, 
#nullable restore
#line 12 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
                 om.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "\r\n        <br>");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "number");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
                                      om.Price

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(13, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => om.Price = __value, om.Price, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    <br>\r\n    ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "checkbox");
            __builder.AddAttribute(17, "checked", 
#nullable restore
#line 17 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
                                                                om.IsActive?"checked":null

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
                                        om.IsActive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => om.IsActive = __value, om.IsActive));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "span");
            __builder.AddMarkupContent(22, "\r\n        this Room is ");
            __builder.AddContent(23, 
#nullable restore
#line 19 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
                       om.IsActive?"Active":"InActive"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    <br>\r\n    ");
            __builder.OpenElement(25, "select");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
                   SelectedRoomProp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectedRoomProp = __value, SelectedRoomProp));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 23 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
         foreach (var prop in om.RoomProps)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "option");
            __builder.AddAttribute(29, "value", 
#nullable restore
#line 25 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
                            prop.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(30, 
#nullable restore
#line 25 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
                                        prop.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 26 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenElement(32, "span");
            __builder.AddContent(33, "Room prop Selected : ");
            __builder.AddContent(34, 
#nullable restore
#line 28 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
                                SelectedRoomProp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n");
            __builder.OpenElement(36, "div");
            __builder.AddMarkupContent(37, "<br>\r\n    ");
            __builder.AddMarkupContent(38, "<h2 class=\"text-info\">Room List</h2>\r\n\r\n    ");
            __builder.OpenElement(39, "table");
            __builder.AddAttribute(40, "class", "table table-dark");
#nullable restore
#line 38 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
         foreach (var room in RoomList)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "tr");
            __builder.OpenElement(42, "td");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "text");
            __builder.AddAttribute(45, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
                                                    room.RoomName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => room.RoomName = __value, room.RoomName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "td");
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "type", "text");
            __builder.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
                                                    room.Price

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => room.Price = __value, room.Price));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
                 foreach (var roomprop in room.RoomProps)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 49 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
                         roomprop.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(55, " - ");
            __builder.AddContent(56, 
#nullable restore
#line 49 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
                                          roomprop.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 50 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 52 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n<br>");
#nullable restore
#line 56 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
 foreach (var room in RoomList)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(58, "p");
            __builder.AddContent(59, 
#nullable restore
#line 58 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
        room.RoomName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(60, "\'s price is ");
            __builder.AddContent(61, 
#nullable restore
#line 58 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
                                  room.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 59 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "D:\PROJECT\HotelApp\HotelAppServer\Pages\LearnBalzor\BindProp.razor"
      
    string SelectedRoomProp = "";
    List<Room> RoomList = new List<Room>();
    Room om = new Room()
    {
        Id = 1,
        RoomName = "football",
        Price = 350,
        IsActive = true,
        RoomProps = new List<RoomProp>()
    {
            new RoomProp()
            {

                Id=1,
                Name="Area",
                Value="300"
            },
            new RoomProp()
            {

                Id=2,
                Name="Occupancy",
                Value="5"
            },

        }


    };

    protected override void OnInitialized()
    {
        base.OnInitialized();
        RoomList.Add(new Room()
        {
            Id = 101,
            RoomName = "king Suite",
            Price = 1200,
            RoomProps = new List<RoomProp>()
{
            new RoomProp()
            {
                Id=1,
                Name="Area",
                Value="300"
            },
             new RoomProp(){
            Id=2,
            Name="Occupancy",
            Value="1"
            }
            }
        });
        RoomList.Add(new Room()
        {

            Id = 201,
            RoomName = "Single Room",
            IsActive = true,
            Price = 300,
            RoomProps = new List<RoomProp>() {
            new RoomProp(){
            Id=1,
            Name="Area",
            Value="30"
            },
            new RoomProp(){
            Id=2,
            Name="Occupancy",
            Value="1"
            },
            }
        });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
