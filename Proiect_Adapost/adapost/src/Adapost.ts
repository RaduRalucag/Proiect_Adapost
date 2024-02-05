import { Animal } from './Animal';
import { Oras } from './Oras';
import { Conditie } from './Conditie';

export interface Adapost {
    id: string;
    name: string;
    locatie: string;
    Animals: Animal[];
    Oras: Oras;
    Conditie: Conditie;
    }