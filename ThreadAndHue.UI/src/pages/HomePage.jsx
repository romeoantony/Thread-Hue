import React from 'react';
import Navbar from '../components/Navbar';
import Hero from '../components/Hero';
import ProductGrid from '../components/ProductGrid';

const HomePage = () => {
  return (
    <main>
      <Navbar />
      <Hero />
      <ProductGrid />
    </main>
  );
};

export default HomePage;
