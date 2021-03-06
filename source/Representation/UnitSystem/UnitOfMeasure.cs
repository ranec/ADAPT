﻿/*******************************************************************************
  * Copyright (C) 2015 AgGateway and ADAPT Contributors
  * Copyright (C) 2015 Deere and Company
  * All rights reserved. This program and the accompanying materials
  * are made available under the terms of the Eclipse Public License v1.0
  * which accompanies this distribution, and is available at
  * http://www.eclipse.org/legal/epl-v10.html <http://www.eclipse.org/legal/epl-v10.html> 
  *
  * Contributors:
  *    Tarak Reddy, Tim Shearouse - initial API and implementation
  *******************************************************************************/

namespace AgGateway.ADAPT.Representation.UnitSystem
{
    public abstract class UnitOfMeasure : IUnit
    {
        public abstract string Label { get; protected set; }

        public abstract string LabelPlural { get; protected set; }

        public string DomainID { get; protected set; }

        public short UomId { get; protected set; }

        public override string ToString()
        {
            return string.Format("{0} ({1})", DomainID, Label);
        }
    }
}
