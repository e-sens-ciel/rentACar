<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Car.aspx.cs" Inherits="RentACar.Views.Admin.Car" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mybody" runat="server">
     
        <br />
        <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <div class ="row">
                    <div class="col"></div>
                    <br />
                    <div class="col"> <h3 align="center">Manage Cars </h3></div>
                    <div class="col"></div>
                </div>
                <br />
                <div class="row">
                    <div class="col">
                        <form>
                              <div class="mb-3">
                                <label for="exampleInputEmail1" class="form-label">License Number</label>
                                <input type="text" class="form-control" id="immatriculationF" placeholder=" Fill with license number " runat="server">
                              </div>
                              <div class="mb-3">
                                <label for="exampleInputEmail1" class="form-label">Brand</label>
                                <input type="text" class="form-control" id="brandF" placeholder="Fill with brand name"  runat="server">
                              </div>
                              <div class="mb-3">
                                <label for="exampleInputEmail1" class="form-label">Model</label>
                                <input type="text" class="form-control" id="modelF" placeholder="Fill with model name"  runat="server">
                              </div>
                              <div class="mb-3">
                                <label for="exampleInputEmail1" class="form-label">Km</label>
                                <input type="text" class="form-control" id="kmF" placeholder="Fill with number of kilometer for the car"  runat="server">
                              </div>
                              <div class="mb-3">
                                <label for="exampleInputEmail1" class="form-label">Notoriety</label>
                                <input type="text" class="form-control" id="notorietyF" placeholder="Fill with notoriety"  runat="server">
                              </div>
                              <div class="mb-3">
                                <label for="exampleInputEmail1" class="form-label">Warehouse</label>
                                <input type="text" class="form-control" id="depotF" placeholder="Fill with Warehouse number"  runat="server">
                              </div>
                            <br />
                              <button type="submit" class="btn btn-primary">Add</button>

                              <button type="submit" class="btn btn-primary">Edit</button>
                              
                              <button type="submit" class="btn btn-primary">Delete</button>
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
