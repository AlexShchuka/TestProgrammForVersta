﻿namespace TestProgrammForVersta.Data
{
    public class Order
    {
        public Order(int id, string? senderCity, string? senderAddress, string? recieverCity, string? recieverAddress, double weight, DateTime date)
        {
            Id = id;
            SenderCity = senderCity;
            SenderAddress = senderAddress;
            RecieverCity = recieverCity;
            RecieverAddress = recieverAddress;
            Weight = weight;
            Date = date;
        }

        public int Id { get; set; }
        public string? SenderCity { get; set; }
        public string? SenderAddress { get; set; }
        public string? RecieverCity { get; set; }
        public string? RecieverAddress { get; set; }
        public double Weight { get; set; }
        public DateTime Date { get; set; }
    }
}
