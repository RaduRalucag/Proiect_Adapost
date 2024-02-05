import { Adapost } from "./Adapost";
import { Carnet_Sanatate } from "./Carnet_Sanatate";
import { AnimalClient } from "./AnimalClient";

export interface Animal {
    id: string;
    nume: string;
    tip: string;
    rasa: string;
    culoare: string;
    Adapost: Adapost;
    Carnet_Sanatate: Carnet_Sanatate;
    AnimalClients: AnimalClient[];
    }