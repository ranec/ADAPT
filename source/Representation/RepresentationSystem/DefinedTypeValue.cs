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
namespace AgGateway.ADAPT.Representation.RepresentationSystem
{
    public class DefinedTypeValue : ICopy<DefinedTypeValue>
    {
        public EnumeratedRepresentation Representation { get; private set; }
        public EnumerationMember EnumerationMember { get; set; }

        public DefinedTypeValue(string representationDomainId)
            : this((EnumeratedRepresentation)RepresentationManager.Instance.Representations[representationDomainId])
        {
            
        }

        public DefinedTypeValue(EnumeratedRepresentation enumeratedRepresentation)
            : this(enumeratedRepresentation, null)
        {
            
        }

        public DefinedTypeValue(string representationDomainId, string enumerationDomainId)
            : this((EnumeratedRepresentation)RepresentationManager.Instance.Representations[representationDomainId], ((EnumeratedRepresentation)RepresentationManager.Instance.Representations[representationDomainId]).EnumerationMembers[enumerationDomainId])
        {

        }

        public DefinedTypeValue(long representationDomainTag, long enumerationDomainTag) :
            this((EnumeratedRepresentation)RepresentationManager.Instance.Representations[representationDomainTag], ((EnumeratedRepresentation)RepresentationManager.Instance.Representations[representationDomainTag]).EnumerationMembers[enumerationDomainTag])
        {
            
        }

        public DefinedTypeValue(EnumeratedRepresentation enumeratedRepresentation, EnumerationMember enumerationMember)
        {
            Representation = enumeratedRepresentation;
            EnumerationMember = enumerationMember;
        }

        public override string ToString()
        {
            return EnumerationMember != null ? EnumerationMember.DomainId : string.Empty;
        }

        public DefinedTypeValue Copy()
        {
            return new DefinedTypeValue(Representation, EnumerationMember);
        }
    }
}
