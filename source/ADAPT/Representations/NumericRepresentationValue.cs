/*******************************************************************************
  * Copyright (C) 2015 AgGateway and ADAPT Contributors
  * Copyright (C) 2015 Deere and Company
  * All rights reserved. This program and the accompanying materials
  * are made available under the terms of the Eclipse Public License v1.0
  * which accompanies this distribution, and is available at
  * http://www.eclipse.org/legal/epl-v10.html <http://www.eclipse.org/legal/epl-v10.html> 
  *
  * Contributors:
  *    Tarak Reddy, Tim Shearouse - initial API and implementation
  *    Joseph Ross  - Updating ToString to acount for Value being a NumericValue
  *******************************************************************************/

using AgGateway.ADAPT.ApplicationDataModel.Common;

namespace AgGateway.ADAPT.ApplicationDataModel.Representations
{
    public class NumericRepresentationValue : RepresentationValue
    {
        public NumericRepresentationValue(NumericRepresentation representation, NumericValue value)
        {
            Representation = representation;
            Value = value;
        }

        public NumericRepresentationValue(NumericRepresentation representation, UnitOfMeasure userProvidedUnitOfMeasure, NumericValue value)
        {
            Representation = representation;
            UserProvidedUnitOfMeasure = userProvidedUnitOfMeasure;
            Value = value;
        }

        public NumericRepresentation Representation { get; set; }

        public NumericValue Value { get; set; }

        public UnitOfMeasure UserProvidedUnitOfMeasure { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} ({2})", Value.Value, UserProvidedUnitOfMeasure.Code, Representation.Code);
        }
    }
}