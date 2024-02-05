import { Adapost } from "./Adapost";
import { Animal } from "./Animal";
import { AnimalClient } from "./AnimalClient";
import { Arhiva } from "./Arhiva";
import { Carnet_Sanatate } from "./Carnet_Sanatate";
import { Client } from "./Client";
import { Conditie } from "./Conditie";
import { Control } from "./Control";
import { Oras } from "./Oras";

const fetchData = async () => {
    try {
        const adapostData = await fetch("https://localhost:7229/Adapost");
        const animalData = await fetch("https://localhost:7229/Animal");
        const animalClientData = await fetch("https://localhost:7229/AnimalClient");
        const arhivaData = await fetch("https://localhost:7229/AArhiva");
        const carnetSanatateData = await fetch("https://localhost:7229/Carnet_Sanatate");
        const clientData = await fetch("https://localhost:7229/Client");
        const conditieData = await fetch("https://localhost:7229/Conditie");
        const controlData = await fetch("https://localhost:7229/Control");
        const orasData = await fetch("https://localhost:7229/Oras");

        const adapostJson = await adapostData.json();
        const animalJson = await animalData.json();
        const animalClientJson = await animalClientData.json();
        const arhivaJson = await arhivaData.json();
        const carnetSanatateJson = await carnetSanatateData.json();
        const clientJson = await clientData.json();
        const conditieJson = await conditieData.json();
        const controlJson = await controlData.json();
        const orasJson = await orasData.json();

        return (
            <div>
                <h1>Adapost Data:</h1>
                <ul>
                    {adapostData.map((adapost) => (
                        <li key={adapost.id}>{adapost.name}</li>
                    ))}
                </ul>
            </div>
        );

    } catch (error) {
        console.error("Error fetching data:", error);
    }
};

fetchData();