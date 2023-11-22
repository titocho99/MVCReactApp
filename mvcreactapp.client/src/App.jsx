import { useEffect, useState } from 'react';
import './App.css';

function App() {
    const [forecasts, setForecasts] = useState();

    useEffect(() => {
        populateWeatherData();
    }, []);

    const contents = forecasts === undefined
        ? <p><em>Loading... Please refresh once the ASP.NET backend has started. See <a href="https://aka.ms/jspsintegrationreact">https://aka.ms/jspsintegrationreact</a> for more details.</em></p>
        : <table className="table table-striped" aria-labelledby="tabelLabel">
            <thead>
                <tr>
                    <th>Nombre</th>
                    <th>Telefono</th>
                    <th>Domicilio</th>
                    <th>Correo</th>
                </tr>
            </thead>
            <tbody>
                {forecasts.map(forecast =>
                    <tr key={forecast.nombre}>
                        <td>{forecast.nombre}</td>
                        <td>{forecast.telefono}</td>
                        <td>{forecast.domicilio}</td>
                        <td>{forecast.correo}</td>
                    </tr>
                )}
            </tbody>
        </table>;

    return (
        <div>
            <h1 id="tabelLabel">Lista de Empleados</h1>
            <p>Datos desde API .NET </p>
            <a target="_blank" href="https://localhost:7059/Empleados">https://localhost:7059/Empleados</a>
            {contents}
        </div>
    );
    
    async function populateWeatherData() {
        const response = await fetch('empleados');
        const data = await response.json();
        setForecasts(data);
    }
}

export default App;