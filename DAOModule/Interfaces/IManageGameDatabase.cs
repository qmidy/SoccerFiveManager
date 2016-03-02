///////////////////////////////////////////////////////////////////////////////
/// © Tous droits réservés. Ce logiciel est la propriété exclusive de DCNS. Il 
/// est protégé en France par le code de la propriété intellectuelle et à 
/// l’étranger par les conventions internationales. Les conditions 
/// d’utilisation du logiciel sont précisées dans la licence accordée par DCNS.
/// Toute utilisation non expressément prévue par cette licence ou toute 
/// reproduction, divulgation, ou diffusion (partielle ou totale) du logiciel,
/// par quelque moyen que ce soit, est strictement interdite. Toute personne ne
/// respectant pas ces dispositions se rendra coupable du délit de contrefaçon
/// et sera passible des sanctions pénales prévues par la loi.
///
/// © All rights reserved. This software shall remain DCNS sole and exclusive 
/// property. It is protected by the provisions of the French Intellectual 
/// Property Code as well as by international rules and regulations. The 
/// conditions of use of this software are defined in the license granted by 
/// DCNS. Any use, other than those expressly granted in this license, 
/// disclosure, dissemination or reproduction (either whole or partial), by any
/// means, of this software is strictly prohibited. Infringement of those 
/// rights will lead to penal sanctions as provided by law.
//////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAOModule
{
    public interface IManageGameDatabase
    {
        void CreateGameDatabase(string clubName);

        List<object> GetPlayers(string clubName);
    }
}
