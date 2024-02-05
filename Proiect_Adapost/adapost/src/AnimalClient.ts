import { Animal } from './Animal';
import { Client } from './Client';

export interface AnimalClient {
    id: string;
    numarAdoptii: number;
    dataAdoptie: string;
    Animal: Animal;
    Client: Client;
    }