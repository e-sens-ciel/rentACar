﻿using Microsoft.AspNetCore.Mvc;
using Web.Interfaces;
using Web.Models;

namespace Web.Controllers
{
    public class ReservationController : Controller
    {
        public IReservationService _reservationService;
        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<ActionResult> GetReservation(int id)
        {
            var reservation = await _reservationService.GetReservation(id);
            return View(reservation);
        }
        public async Task<ActionResult> GetAllReservations()
        {
            var reservations = await _reservationService.GetAllReservations();
            return View(reservations);
        }

        public async Task<ActionResult> EditReservation(int id)
        {
            var reservation = await _reservationService.GetReservation(id);
            return View(reservation);
        }
        public async Task<ActionResult> UpdateReservation(Reservation reservation)
        {
            var reservations = await _reservationService.UpdateReservation(reservation);
            return View(reservations);
        }
        public async Task<ActionResult> DeleteReservation(int id)
        {
            //Reservation reservation = await _reservationService.GetReservation(id);
            var deleteReservation = await _reservationService.DeleteReservation(id);
            return View();
        }
    }
}
