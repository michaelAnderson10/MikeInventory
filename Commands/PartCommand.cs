using MikeInventory.Data;
using MikeInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MikeInventory.ViewModels;
using System.ComponentModel;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace MikeInventory.Commands
{
    public class PartCommand : BaseCommand
    {

        private readonly PartViewModel _viewModel;

        public PartCommand(PartViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object? parameter)
        {          
            PartDataAccess.AddPart(_viewModel.PartId, _viewModel.PartDescription, _viewModel.PartQuantity, _viewModel.PartTag, _viewModel.UserIdToDb);           
        }





        //public void PartOjectMtd(int partID, string partDescription, int partQuantity, string partTag, int userId)
        //{
        //    using var context = new MikeInventoryContext();
        //    var part = new Part
        //    {
        //        PartId = partID,
        //        PartDescription = partDescription,
        //        PartQuantity = partQuantity,
        //        PartTag = partTag,
        //        UserID = userId,
        //    };
        //    PartDataAccess.AddPart(part, context);


        //}

        //private readonly int _partId;
        //private readonly string _partDescription;
        //private readonly int _partQuantity;
        //private readonly string _partTag;
        //private readonly int _userId;


        //public PartCommand(int partId, string partDescription, int partQuantity, string partTag, int userId)
        //{
        //    _partId = partId;
        //    _partDescription = partDescription;
        //    _partQuantity = partQuantity;
        //    _partTag = partTag;
        //    _userId = userId;

        //}

    }   
}

