﻿//------------------------------------------------------------------------------
//                         COPYRIGHT 2009 GUIDEBEE
//                           ALL RIGHTS RESERVED.
//                     GUIDEBEE CONFIDENTIAL PROPRIETARY 
///////////////////////////////////// REVISIONS ////////////////////////////////
// Date       Name                 Tracking #         Description
// ---------  -------------------  ----------         --------------------------
// 07JUN2009  James Shen                 	          Initial Creation
////////////////////////////////////////////////////////////////////////////////
//--------------------------------- IMPORTS ------------------------------------
using System;
using System.IO;

//--------------------------------- PACKAGE ------------------------------------
namespace MapDigit.AJAX.JSON
{
    //[-------------------------- MAIN CLASS ----------------------------------]
    ////////////////////////////////////////////////////////////////////////////
    //----------------------------- REVISIONS ----------------------------------
    // Date       Name                 Tracking #         Description
    // --------   -------------------  -------------      ----------------------
    // 07JUN2009  James Shen                 	          Initial Creation
    ////////////////////////////////////////////////////////////////////////////
    /**
     * JSONStringer provides a quick and convenient way of producing JSON text.
     * The texts produced strictly conform to JSON syntax rules. No whitespace is
     * added, so the results are ready for transmission or storage. Each instance of
     * JSONStringer can produce one JSON text.
     * <p>
     * A JSONStringer instance provides a <code>value</code> method for appending
     * values to the
     * text, and a <code>key</code>
     * method for adding keys before values in objects. There are <code>array</code>
     * and <code>endArray</code> methods that make and bound array values, and
     * <code>object</code> and <code>endObject</code> methods which make and bound
     * object values. All of these methods return the JSONWriter instance,
     * permitting cascade style. For example, <pre>
     * myString = new JSONStringer()
     *     .object()
     *         .key("JSON")
     *         .value("Hello, World!")
     *     .endObject()
     *     .toString();</pre> which produces the string <pre>
     * {"JSON":"Hello, World!"}</pre>
     * <p>
     * The first method called must be <code>array</code> or <code>object</code>.
     * There are no methods for adding commas or colons. JSONStringer adds them for
     * you. Objects and arrays can be nested up to 20 levels deep.
     * <p>
     * This can sometimes be easier than using a JSONObject to build a string.
     * <hr><b>&copy; Copyright 2009 Guidebee, Inc. All Rights Reserved.</b>
     * @version     1.00, 07/06/09
     * @author      Guidebee, Inc. & JSON.org
     */
    public class JSONStringer : JSONWriter
    {

        ////////////////////////////////////////////////////////////////////////////
        //--------------------------------- REVISIONS ------------------------------
        // Date       Name                 Tracking #         Description
        // ---------  -------------------  -------------      ----------------------
        // 07JUN2009  James Shen                 	          Initial Creation
        ////////////////////////////////////////////////////////////////////////////
        /**
         * Make a fresh JSONStringer. It can be used to build one JSON text.
         */
        public JSONStringer()
            : base(new StringWriter())
        {

        }

        ////////////////////////////////////////////////////////////////////////////
        //--------------------------------- REVISIONS ------------------------------
        // Date       Name                 Tracking #         Description
        // ---------  -------------------  -------------      ----------------------
        // 07JUN2009  James Shen                 	          Initial Creation
        ////////////////////////////////////////////////////////////////////////////
        /**
         * Return the JSON text. This method is used to obtain the product of the
         * JSONStringer instance. It will return <code>null</code> if there was a
         * problem in the construction of the JSON text (such as the calls to
         * <code>array</code> were not properly balanced with calls to
         * <code>endArray</code>).
         * @return The JSON text.
         */
        public override string ToString()
        {
            return _mode == 'd' ? _writer.ToString() : null;
        }
    }
}