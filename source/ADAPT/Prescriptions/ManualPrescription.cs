﻿/*******************************************************************************
  * Copyright (C) 2015 AgGateway and ADAPT Contributors
  * Copyright (C) 2015 Deere and Company
  * All rights reserved. This program and the accompanying materials
  * are made available under the terms of the Eclipse Public License v1.0
  * which accompanies this distribution, and is available at
  * http://www.eclipse.org/legal/epl-v10.html <http://www.eclipse.org/legal/epl-v10.html> 
  *
  * Contributors:
  *    Justin Sliekers - initial API and implementation
  *    Justin Sliekers - dropping product uses and application strategy, adding rate
  *******************************************************************************/

namespace AgGateway.ADAPT.ApplicationDataModel.Prescriptions
{
    public class ManualPrescription : Prescription
    {
        public double Rate { get; set; }
    }
}
