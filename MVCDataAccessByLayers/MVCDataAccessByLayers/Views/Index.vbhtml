﻿@C@Model IEnumerable<BusinessLayer.Employee>

    @{
    ViewBag.Title = "Index";
    }
    <div class="container">
        <div class="jumbotron text-center"><h1>Employee Details</h1></div>


        <p>
            @Html.ActionLink("Create New", "Create")
        </p>
        <table class="table">
            <tr>
                <th>
                    Name
                </th>
                <th>
                    Gender
                </th>
                <th>
                    Designation
                </th>
                <th></th>
            </tr>

            @foreach (var item in Model)
            {
            <tr>
                <td>
                    @Html.DisplayFor(modelItem >= item.EmployeeName)
                </td>
                <td>
                    @Html.DisplayFor(modelItem >= item.EmployeeGender)
                </td>
                <td>
                    @Html.DisplayFor(modelItem >= item.EmployeeDesignation)
                </td>
                <td>
                    @Html.ActionLink("Edit", "Edit", New { id = item.EmployeeID }) |
                    @Html.ActionLink("Details", "Details", New { id = item.EmployeeID }) |
                    @Html.ActionLink("Delete", "Delete", New { id = item.EmployeeID })
                </td>
            </tr>
            }

        </table>
    </div>
