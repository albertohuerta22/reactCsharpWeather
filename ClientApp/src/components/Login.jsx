// LoginForm.tsx
import React from 'react';

const LoginForm: React.FC = () => {
    return (
       <div>
        <h2>Login < /h2>
        < form >
        <div>
            <label htmlFor= "username" > Username: </label>
                < input type = "text" id = "username" />
                    </div>
        < div >
        <label htmlFor="password" > Password: </label>
            < input type = "password" id = "password" />
                </div>
        < div >
        <button type="button" >
            Login
            < /button>
            < /div>
        </form>
       </div>
    );
};

export default LoginForm;
