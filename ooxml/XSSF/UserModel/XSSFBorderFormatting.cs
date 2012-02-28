/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for Additional information regarding copyright ownership.
   The ASF licenses this file to You under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
==================================================================== */
using NPOI.SS.UserModel;
using NPOI.OpenXmlFormats.Spreadsheet;
namespace NPOI.XSSF.UserModel
{

/**
 * @author Yegor Kozlov
 */
    public class XSSFBorderFormatting : IBorderFormatting
    {
        CT_Border _border;

        /*package*/
        internal XSSFBorderFormatting(CT_Border border)
        {
            _border = border;
        }

        #region IBorderFormatting Members

        public short BorderBottom
        {
            get
            {
                ST_BorderStyle? ptrn = _border.IsSetBottom() ? _border.bottom.style : (ST_BorderStyle?)null;
                return ptrn == null ? (short)BorderStyle.NONE : (short)(ptrn - 1);
            }
            set
            {
                CT_BorderPr pr = _border.IsSetBottom() ? _border.bottom : _border.AddNewBottom();
                if (value == (short)BorderStyle.NONE) _border.unsetBottom();
                else pr.style = (ST_BorderStyle)(value + 1);
            }
        }

        public short BorderDiagonal
        {
            get
            {
                ST_BorderStyle? ptrn = _border.IsSetDiagonal() ? _border.diagonal.style : null;
                return ptrn == null ? (short)BorderStyle.NONE : (short)(ptrn - 1);
            }
            set
            {
                CT_BorderPr pr = _border.IsSetDiagonal() ? _border.diagonal : _border.AddNewDiagonal();
                if (value == (short)BorderStyle.NONE) _border.unsetDiagonal();
                else pr.style = (ST_BorderStyle)(value + 1);
            }
        }

        public short BorderLeft
        {
            get
            {
                ST_BorderStyle? ptrn = _border.IsSetLeft() ? _border.left.style : null;
                return ptrn == null ? (short)BorderStyle.NONE : (short)(ptrn - 1);
            }
            set
            {
                CT_BorderPr pr = _border.IsSetLeft() ? _border.left : _border.AddNewLeft();
                if (value == (short)BorderStyle.NONE) _border.unsetLeft();
                else pr.style = (ST_BorderStyle)(value + 1);
            }
        }

        public short BorderRight
        {
            get
            {
                ST_BorderStyle? ptrn = _border.IsSetRight() ? _border.right.style : null;
                return ptrn == null ? (short)BorderStyle.NONE : (short)(ptrn - 1);
            }
            set
            {
                CT_BorderPr pr = _border.IsSetRight() ? _border.right : _border.AddNewRight();
                if (value == (short)BorderStyle.NONE) _border.unsetRight();
                else pr.style = (ST_BorderStyle)(value + 1);
            }
        }

        public short BorderTop
        {
            get
            {
                ST_BorderStyle? ptrn = _border.IsSetTop() ? _border.top.style : null;
                return ptrn == null ? (short)BorderStyle.NONE : (short)(ptrn - 1);

            }
            set
            {
                CT_BorderPr pr = _border.IsSetTop() ? _border.top : _border.AddNewTop();
                if (value == (short)BorderStyle.NONE) _border.unsetTop();
                else pr.style = (ST_BorderStyle)(value + 1);
            }
        }

        public short BottomBorderColor
        {
            get
            {
                if (!_border.IsSetBottom()) return 0;

                CT_BorderPr pr = _border.bottom;
                return (short)pr.color.indexed;
            }
            set
            {
                CT_BorderPr pr = _border.IsSetBottom() ? _border.bottom : _border.AddNewBottom();

                CT_Color ctColor = new CT_Color();
                ctColor.indexed = (value);
                pr.color = (ctColor);
            }
        }

        public short DiagonalBorderColor
        {
            get
            {
                if (!_border.IsSetDiagonal()) return 0;

                CT_BorderPr pr = _border.diagonal;
                return (short)pr.color.indexed;
            }
            set
            {
                CT_BorderPr pr = _border.IsSetDiagonal() ? _border.diagonal : _border.AddNewDiagonal();

                CT_Color ctColor = new CT_Color();
                ctColor.indexed = (value);
                pr.color = (ctColor);
            }
        }

        public short LeftBorderColor
        {
            get
            {
                if (!_border.IsSetLeft()) return 0;

                CT_BorderPr pr = _border.left;
                return (short)pr.color.indexed;
            }
            set
            {
                CT_BorderPr pr = _border.IsSetLeft() ? _border.left : _border.AddNewLeft();

                CT_Color ctColor = new CT_Color();
                ctColor.indexed = (value);
                pr.color = (ctColor);
            }
        }

        public short RightBorderColor
        {
            get
            {
                if (!_border.IsSetRight()) return 0;

                CT_BorderPr pr = _border.right;
                return (short)pr.color.indexed;
            }
            set
            {
                CT_BorderPr pr = _border.IsSetRight() ? _border.right : _border.AddNewRight();

                CT_Color ctColor = new CT_Color();
                ctColor.indexed = (value);
                pr.color = (ctColor);
            }
        }

        public short TopBorderColor
        {
            get
            {
                if (!_border.IsSetTop()) return 0;

                CT_BorderPr pr = _border.top;
                return (short)pr.color.indexed;
            }
            set
            {
                CT_BorderPr pr = _border.IsSetTop() ? _border.top : _border.AddNewTop();

                CT_Color ctColor = new CT_Color();
                ctColor.indexed = (value);
                pr.color = (ctColor);
            }
        }

        #endregion
    }
}



