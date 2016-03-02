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

using DAOModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary
{
    public static class DaoService
    {
        public static string clubNameStatic;

        public static void CreateGameDatabase(string clubName)
        {
            clubNameStatic = clubName;
            IManageGameDatabase manageGameDatabase = new ManageGameDatabase(clubName);
            manageGameDatabase.CreateGameDatabase(clubName);
        }

        public static List<IPlayer> GetPlayers()
        {
            List<IPlayer> result = new List<IPlayer>();

            IManageGameDatabase manageGameDatabase = new ManageGameDatabase(clubNameStatic);

            // On récupère un tableau qui renvoie une donnée par case
            // IE => [0] : Id du joueur / [1] : Nom du joueur / [2] : Club Id / [3] : Area / [4] : Number / [5] : Attack / [6] : Defense
            var playerObjects = manageGameDatabase.GetPlayers(clubNameStatic);
            var playersNumber = playerObjects.Count / 7;
            var playerShift = 7;

            for (int i = 0; i < playersNumber; ++i)
            {
                IPlayer player = new Player();
                player.Name = (string)playerObjects[i * playerShift + 1];
                // player.Club = ...
                player.Area = (EnumArea)Enum.Parse(typeof(EnumArea), playerObjects[i * playerShift + 3].ToString());
                player.Number = int.Parse(playerObjects[i * playerShift + 4].ToString());
                player.Attack = int.Parse(playerObjects[i * playerShift + 5].ToString());
                player.Defense = int.Parse(playerObjects[i * playerShift + 6].ToString());
                result.Add(player);
            }

            return result;
        }
    }
}
