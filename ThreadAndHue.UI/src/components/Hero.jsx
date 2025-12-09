import React from 'react';

const Hero = () => {
  return (
    <section className="hero">
      <div className="hero-bg">
        <img src="https://images.unsplash.com/photo-1445205170230-053b83016050?q=80&w=2000&auto=format&fit=crop" alt="Hero" />
        <div className="overlay"></div>
      </div>
      <div className="container hero-content">
        <h1>THE NEW<br />COLLECTION</h1>
        <p>Minimal design. Maximum impact.</p>
        <a href="#" className="btn btn-white">Shop Now</a>
      </div>
    </section>
  );
};

export default Hero;
