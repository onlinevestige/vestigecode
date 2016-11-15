﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReturnsComponent.BusinessObjects
{
    [ Serializable]
   public  class RetVendorBatchDetails 
    {
      public RetVendorBatchDetails()
      {

      }
      public decimal LineTaxAmount
      { get; set; }

      public decimal DBLineTaxAmount
      {
          get { return Math.Round((decimal)LineTaxAmount, CoreComponent.Core.BusinessObjects.Common.DBAmountRounding, MidpointRounding.AwayFromZero); }
          set { throw new NotImplementedException("This property can not be explicitly set"); }
      }

      public decimal DisplayLineTaxAmount
      {
          get { return Math.Round((decimal)DBLineTaxAmount, CoreComponent.Core.BusinessObjects.Common.DisplayAmountRounding, MidpointRounding.AwayFromZero); }
          set { throw new NotImplementedException("This property can not be explicitly set"); }
      }
      public string GRNInvoiceNumber
      { get; set; }

      public int GRNInvoiceType
      { get; set; }

      public double GRNReceivedQty
      { get; set; }

      public double DBGRNReceivedQty
      {
          get
          { return Math.Round((double)GRNReceivedQty, CoreComponent.Core.BusinessObjects.Common.DBQtyRounding, MidpointRounding.AwayFromZero); }
          set
          { throw new NotImplementedException("This property can not be explicitly set"); }
      }
      public double DisplayGRNReceivedQty
      {
          get
          {
              return Math.Round((double)DBGRNReceivedQty, CoreComponent.Core.BusinessObjects.Common.DisplayQtyRounding, MidpointRounding.AwayFromZero);
          }
          set
          {
              throw new NotImplementedException("This property can not be explicitly set");
          }
      }
      public string ReturnNo
      {
          get; set;
      }
      public int ReturnQty
      {get; set;}

      public double DBReturnQty
      {
          get
          {
              return Math.Round((double)ReturnQty, CoreComponent.Core.BusinessObjects.Common.DBQtyRounding, MidpointRounding.AwayFromZero);
          }
          set
          {
              throw new NotImplementedException("This property can not be explicitly set");
          }
      }

      public double DisplayReturnQty
      {
          get
          {
              return Math.Round((double)DBReturnQty, CoreComponent.Core.BusinessObjects.Common.DisplayQtyRounding, MidpointRounding.AwayFromZero);
          }
          set
          {
              throw new NotImplementedException("This property can not be explicitly set");
          }
      }
      
      public int ItemId
      { get; set; }
      public double POQty
      { get; set; }

      public double DBPOQty
      {
          get
          {
              return Math.Round((double)POQty, CoreComponent.Core.BusinessObjects.Common.DBQtyRounding, MidpointRounding.AwayFromZero);
          }
          set
          {
              throw new NotImplementedException("This property can not be explicitly set");
          }
      }

      public double DisplayPOQty
      {
          get
          {
              return Math.Round((double)DBPOQty, CoreComponent.Core.BusinessObjects.Common.DisplayQtyRounding, MidpointRounding.AwayFromZero);
          }
          set
          {
              throw new NotImplementedException("This property can not be explicitly set");
          }
      }
      
      public string PODate
      { get; set; }

      public String DisplayPODate
      {
          get
          {
              if ((PODate != null) && (PODate.Length > 0))
              {
                  return Convert.ToDateTime(PODate).ToString(CoreComponent.Core.BusinessObjects.Common.DTP_DATE_FORMAT);
              }
              else
              {
                  return String.Empty;
              }
          }
          set
          {
              throw new NotImplementedException("This property can not be explicitly set");
          }
      }

      public double POAmount
      { get; set; }

      public double DBPOAmount
      {
          get
          {
              return Math.Round(POAmount, CoreComponent.Core.BusinessObjects.Common.DBAmountRounding, MidpointRounding.AwayFromZero);
          }
          set
          {
              throw new NotImplementedException("This property can not be explicitly set");
          }
      }

      public double DisplayPOAmount
      {
          get
          {
              return Math.Round(DBPOAmount, CoreComponent.Core.BusinessObjects.Common.DisplayAmountRounding, MidpointRounding.AwayFromZero);
          }
          set
          {
              throw new NotImplementedException("This property can not be explicitly set");
          }
      }

      public string BatchNo
      { get; set; }
      public string PONumber
      { get; set; }
      public int BucketId
      { get; set; }
      public string ReturnReason
      { get; set; }
    }
}
