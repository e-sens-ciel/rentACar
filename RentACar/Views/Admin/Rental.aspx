<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Rental.aspx.cs" Inherits="RentACar.Views.Admin.Rental" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mybody" runat="server">

<br />
        <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <div class ="row">
                    <div class="col"></div>
                    <br />
                    <div class="col"> <h3 align="center">Manage Rentals </h3></div>
                    <div class="col"></div>
                </div>
                <br />
                <div class="row">
                    <div class="col">
                        <form>
                              <div class="mb-3">
                                <label for="exampleInputEmail1" class="form-label">License Number</label>
                                <input type="text" class="form-control" id="immatriculation" runat="server">
                              </div>
                              <div class="mb-3">
                                <label for="exampleInputEmail1" class="form-label">Client</label>
                                <input type="text" class="form-control" id="clientF"  runat="server">
                              </div>
                              <div class="mb-3">
                                <label for="exampleInputEmail1" class="form-label">Starting Warehouse</label>
                                <input type="text" class="form-control" id="SWarehouseF"   runat="server">
                              </div>
                              <div class="mb-3">
                                <label for="exampleInputEmail1" class="form-label">Arrival Warehouse</label>
                                <input type="text" class="form-control" id="AwarehouseF"   runat="server">
                              </div>
                              <div class="mb-3">
                                <label for="exampleInputEmail1" class="form-label">Status</label>
                                <input type="text" class="form-control" id="statusF"   runat="server">
                              </div>

                            <br />

                              <button type="submit" class="btn btn-primary">Edit</button>               

                       </form>
                    </div>
                </div>
            </div>
            <div class="col-md-8">
                <table class="table">

                </table>
            </div>
        </div>
    </div>

</asp:Content>

