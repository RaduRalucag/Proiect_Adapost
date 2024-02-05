import React, {useRef} from 'react';
import { useForm } from 'react-hook-form';

const RegisterForm = ({ onSubmit }) => {
  const { register, handleSubmit, errors } = useForm();

  return (
    <form onSubmit={handleSubmit(onSubmit)}>
      <div>
        <label>Nume:</label>
        <input type="text" name="Nume" ref={register({ required: true })} />
        {errors.Nume && <span>Numele este obligatoriu.</span>}
      </div>
      <div>
        <label>Parola:</label>
        <input type="password" name="Parola" ref={register({ required: true })} />
        {errors.Parola && <span>Parola este obligatorie.</span>}
      </div>
      <button type="submit">Inregistrare</button>
    </form>
  );
};

export default RegisterForm;
