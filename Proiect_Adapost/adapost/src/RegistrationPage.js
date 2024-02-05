import React, { useState } from "react";
import axios from "axios";

const RegistrationPage = () => {
  const [formData, setFormData] = useState({
    username: "",
    password: "",
    role: "User",
  });

  const [token, setToken] = useState(null);
  const [registrationSuccess, setRegistrationSuccess] = useState(false);
  const [loginSuccess, setLoginSuccess] = useState(false);

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData({
      ...formData,
      [name]: value,
    });
  };

  const handleRegistration = () => {
    console.log("handleRegistration function called", formData);

    const registrationEndpoint = `https://localhost:7229/api/Auth/Register_${formData.role.toLowerCase()}`;
    axios
      .post(registrationEndpoint, formData)
      .then((response) => {
        console.log("Registration successful:", response.data);
        setRegistrationSuccess(true);
        setLoginSuccess(false);
      })
      .catch((error) => {
        console.error("Registration failed:", error);
        setRegistrationSuccess(false);
      });
  };

  const handleLogin = () => {
    console.log("handleLogin function called", formData);

    const loginEndpoint = "https://localhost:7229/api/Auth/Login";
    axios
      .post(loginEndpoint, formData)
      .then((response) => {
        console.log("Login successful:", response.data);
        setToken(response.data.token);
        setLoginSuccess(true);
        setRegistrationSuccess(false);
      })
      .catch((error) => {
        console.error("Login failed:", error);
        setLoginSuccess(false);
      });
  };

  return (
    <div>
      <h2>Registration Page</h2>
      <form onSubmit={(e) => e.preventDefault()}>
        <label>
          Username:
          <input
            type="text"
            name="username"
            value={formData.username}
            onChange={handleChange}
          />
        </label>
        <br />
        <label>
          Password:
          <input
            type="password"
            name="password"
            value={formData.password}
            onChange={handleChange}
          />
        </label>
        <br />
        <label>
          Role:
          <select name="role" value={formData.role} onChange={handleChange}>
            <option value="User">User</option>
            <option value="Admin">Admin</option>
            <option value="Doctor">Doctor</option>
            <option value="Inspector">Inspector</option>
          </select>
        </label>
        <br />
        <button type="button" onClick={handleRegistration}>
          Register
        </button>
        <button type="button" onClick={handleLogin}>
          Login
        </button>
      </form>

      {registrationSuccess && (
        <div>
          <h2>Registration Successful</h2>
        </div>
      )}

      {loginSuccess && (
        <div>
          <h2>Login Successful</h2>
          <p>Token: {token}</p>
        </div>
      )}
    </div>
  );
};

export default RegistrationPage;
