import React, {useState} from "react";
import './App.css';
import axios from "axios"; 
import RegistrationPage from "./RegistrationPage";
import Info from "./Info";
// import { config } from "./config"
// import { Adapost } from "./Adapost";
// import { Animal } from "./Animal";
// import { AnimalClient } from "./AnimalClient";
// import { Arhiva } from "./Arhiva";
// import { Carnet_Sanatate } from "./Carnet_Sanatate";
// import { Client } from "./Client";
// import { Conditie } from "./Conditie";
// import { Control } from "./Control";
// import { Oras } from "./Oras";
// import { RefreshToken } from "./RefreshToken";
// import { Role } from "./Role";
// import { User } from "./User";


const config = {
};

function App() {
  const [responseData, setResponseData] = useState(null);

  const fetchData = (url) => {
    axios
      .get(url, config)
      .then((response) => {
        setResponseData(response.data);
      })
      .catch((error) => {
        console.error("Error fetching data:", error);
      });
  };

  return (
    <div className="App">
      <header className="App-header">
        <h1>ADAPOST</h1>
      </header>

      <Info />

      {responseData && (
        <div>
          <h2>Response Data</h2>
          <pre>{JSON.stringify(responseData, null, 2)}</pre>
        </div>
      )}
    </div>
  );
}


export default App;
