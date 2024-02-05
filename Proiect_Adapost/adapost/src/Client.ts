import { AnimalClient } from "./AnimalClient";

export interface Client {
    id: string;
    nume: string;
    prenume: string;
    telefon: string;
    AnimalClients: AnimalClient[];
    }