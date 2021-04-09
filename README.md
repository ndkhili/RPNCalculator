# RPNCalculator


##DONE##
J'ai mis en place une architecture Hexagonal (qui manque les adaptateurs et les connecteurs):
- Une couche domain qui contient les types d'operations et les règles métiers
- Une couche Service qui utilisent la couche domain pour effectuer les opérations
- Une couche API qui exposent ces méthodes en appelant le couche services
- Un projet de test pour la couche service

####


##TO DO##
- Compléter les méthodes manquantes dans la couche Service
- Découper le controlleur en deux pour avoir un pour les operateurs et autre pour les stack
- Implémenter des uses cases ayant des input et des output dans la couche Service en se basant sur DIP afin d'avoir une architecture Hexagonal clean
- Implemnter des Presenter dans la couche API (qui seront appelés par les controleurs) pour gérer les Request et les Response et éviter de trop écrire dans le controleur.
- Compléter les tests unitaires de la couche Services
- Rajouter des proets de tests pour la couche Domain et API
