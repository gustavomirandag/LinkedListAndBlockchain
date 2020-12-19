using ConsoleApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Models
{
    public class Block
    {
        public string Id { get; set; } //Block Hash
        public string Content { get; set; } //Payload
        public string PreviousBlockId { get; set; } //Previous Block Hash

        public Block(string content, string previousBlockId)
        {
            Content = content;
            PreviousBlockId = previousBlockId;

            Id = HashService.sha256Hash(Content + previousBlockId);
        }
    }
}
