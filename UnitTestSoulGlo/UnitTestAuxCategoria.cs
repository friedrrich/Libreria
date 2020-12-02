using System;
using Libreria;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestSoulGlo
{
    [TestClass]
    public class UnitTestAuxCategoria
    {
        #region Pruebas a Agregar Categoria
        [TestMethod]
        public void TestAgregarCategoriaComoObjeto()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();
            Categoria categoria = new Categoria();

            categoria.Idcategoria = 1;
            categoria.Nombre = "Shampoo";
            categoria.Descripcion = "El mejor shampoo del mundo";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            resultadoObtenido = auxCategoria.Agregar(categoria);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void TestAgregarCategoriaConParametros()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();

            var idcat = 1;
            var nom = "Shampoo";
            var desc = "El mejor shampoo del mundo";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            resultadoObtenido = auxCategoria.Agregar(idcat, nom, desc);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void TestAgregarCategoriaComoObjetoSinNombre()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();
            Categoria categoria = new Categoria();


            categoria.Idcategoria = 1;
            categoria.Descripcion = "El mejor shampoo del mundo";
            categoria.Nombre = null;

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            resultadoObtenido = auxCategoria.Agregar(categoria);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void TestAgregarCategoriaComoObjetoSinDescripcion()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();
            Categoria categoria = new Categoria();


            categoria.Idcategoria = 1;
            categoria.Nombre = "Shampoo";



            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            resultadoObtenido = auxCategoria.Agregar(categoria);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void TestAgregarCategoriaComoObjetoSinIdCategoria()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();
            Categoria categoria = new Categoria();

            categoria.Nombre = "Shampoo";
            categoria.Descripcion = "El mejor shampoo del mundo";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            resultadoObtenido = auxCategoria.Agregar(categoria);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        #endregion Pruebas a Agregar Categoria

        #region pruebas a Modificar Categoria
        [TestMethod]
        public void TestModificarCategoriaComoObjeto()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();
            int Idcategoria = 1;
            string Nombre = "Balsamo";
            string Descripcion = "El mejor Balsamo del mundo";
            int resultadoEsperado = 1;
            int resultadoObtenido = 0;
            //Agregar Categoria
            Categoria categoria = new Categoria(Idcategoria,Nombre,Descripcion);            

            //ACT
            resultadoObtenido = categoria.Idcategoria;

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void TestModificarCategoriaConParametros()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();

            var Idcategoria = 2;
            var Nombre = "Shampoo";
            var Descripcion = "El mejor shampoo del mundo";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            resultadoObtenido = auxCategoria.Modificar(Idcategoria, Nombre, Descripcion);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void TestModificarCategoriaComoObjetoSinNombre()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();
            Categoria categoria = new Categoria();


            int Idcategoria = 0;
            string Descripcion = "El mejor shampoo del mundo";
            string Nombre = null;
            auxCategoria.Agregar(categoria);
            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //ACT
            categoria = new Categoria(Idcategoria, Nombre, Descripcion);
            categoria.Idcategoria = 1;
            categoria.Nombre = "EL MEJOR SHAMPOO DEL MUNDO";
            
            

            resultadoObtenido = auxCategoria.Modificar(categoria);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void TestModificarCategoriaComoObjetoSinDescripcion()
        {
            //Arrange
            Categoria cat; 
            
            int Idcategoria = 1;
            string Nombre = "Shampo casero";
            string descripcion = null;
            int resultadoEsperado = 2;
            int resultadoObtenido = 0;
            

            //ACT
            cat = new Categoria(Idcategoria, Nombre, descripcion);
            cat.Idcategoria = 2;
            resultadoObtenido = cat.Idcategoria;

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void TestModificarCategoriaComoObjetoSinIdCategoria()
        {
            //Arrange
            AuxCategoria auxCategoria = new AuxCategoria();
            
            int resultadoEsperado = 0;
            int resultadoObtenido = 0;
            Categoria categoria = new Categoria();

            categoria.Nombre = "Shampoo";
            categoria.Descripcion = "El mejor shampoo del mundo";

            //ACT
            resultadoObtenido = auxCategoria.Modificar(categoria);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        #endregion pruebas a Modificar Categoria

        #region eliminar categoria
        [TestMethod]
        public void TestEliminarCategoriaConIdExistente()
        {
            //Arrange Eliminar
            AuxCategoria auxCategoria = new AuxCategoria();
            int idCategoriaExistente = 1;

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;
            //Agregar

            Categoria categoria = new Categoria();
            categoria.Idcategoria = 1;
            categoria.Nombre = "Shampoo"; 
            categoria.Descripcion = "El mejor shampoo del mundo";
            auxCategoria.Agregar(categoria);


            //ACT
            auxCategoria.Eliminar(categoria.Idcategoria);
            resultadoObtenido = categoria.Idcategoria;
            
            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void TestEliminarCategoriaConIdNoExistente()
        {
            //Arrange Eliminar
            AuxCategoria auxCategoria = new AuxCategoria();
            int idCategoriaNoExistente = 99;

            int resultadoEsperado = 0;
            int resultadoObtenido = 1;


            //ACT
            resultadoObtenido = auxCategoria.Eliminar(idCategoriaNoExistente);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);


        }
        #endregion eliminar categoria

        #region Generar instancias de Categoria
        [TestMethod]
        public void GenerarInstanciaCategoriaSinParametros()
        {
            //Arrange
            Categoria categoria;
            //act
            categoria = new Categoria();
            //assert
            Assert.IsNotNull(categoria);

        }

        [TestMethod]
        public void GenerarInstanciaCategoriaConParametros()
        {
            //Arrange
            Categoria categoria;
            int idCategoria = 10;
            string nombre = "Balsamo";
            string Descripcion = "El mejor balsamo del mundo";
            //act
            categoria = new Categoria(idCategoria, nombre, Descripcion);
            //assert
            Assert.IsNotNull(categoria);

        }
        #endregion Generar instancias de Categoria

        #region obtener parametros de instancias de Categoria
        [TestMethod]
        public void ObtenerIdCategoria()
        {
            //Arrange
            Categoria categoria;
            int idCategoria = 0;
            string nombre = "Balsamo";
            string Descripcion = "El mejor balsamo del mundo";

            int resultadoEsperado = 10;
            int resultadoObtenido = 0;
            //act
            categoria = new Categoria(idCategoria, nombre, Descripcion);
            categoria.Idcategoria = 10;
            resultadoObtenido = categoria.Idcategoria;
            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void ObtenerNombre()
        {
            //Arrange
            Categoria categoria;
            int idCategoria = 10;
            string nombre = "Balsamo";
            string Descripcion = "El mejor balsamo del mundo";

            string resultadoEsperado = "Balsamo";
            string resultadoObtenido = "";
            //act
            categoria = new Categoria(idCategoria, nombre, Descripcion);

            resultadoObtenido = categoria.Nombre;
            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void ObtenerDescripcion()
        {
            //Arrange
            Categoria categoria;
            int idCategoria = 10;
            string nombre = "Balsamo";
            string Descripcion = "El mejor balsamo del mundo";

            string resultadoEsperado = "El mejor balsamo del mundo";
            string resultadoObtenido = "";
            //act
            categoria = new Categoria(idCategoria, nombre, Descripcion);

            resultadoObtenido = categoria.Descripcion;
            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);


        }
        #endregion obtener parametros de instancias de  Categoria

        #region Definir parametros de instancias de Categoria
        [TestMethod]
        public void DefinirIdCategoria()
        {
            //Arrange
            Categoria categoria;
            int idCategoria = 10;
            string nombre = "Balsamo";
            string Descripcion = "El mejor balsamo del mundo";

            int resultadoEsperado = 12;
            int resultadoObtenido = 0;

            //act
            categoria = new Categoria(idCategoria, nombre, Descripcion);
            categoria.Idcategoria = 12;
            resultadoObtenido = categoria.Idcategoria;

            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void DefinirNombre()
        {
            //Arrange
            Categoria categoria;
            int idCategoria = 123;
            string nombre = "Balsamo";
            string Descripcion = "El mejor balsamo del mundo";

            string resultadoEsperado = "Shampoo";
            string resultadoObtenido = "";

            //act
            categoria = new Categoria(idCategoria, nombre, Descripcion);
            categoria.Nombre = "Shampoo";
            resultadoObtenido = categoria.Nombre;

            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        [TestMethod]
        public void DefinirDescripcion()
        {
            //Arrange
            Categoria categoria;
            int idCategoria = 123;
            string nombre = "Balsamo";
            string Descripcion = "El mejor balsamo del mundo";

            string resultadoEsperado = "El casi mejor balsamo del mundo";
            string resultadoObtenido = "";

            //act
            categoria = new Categoria(idCategoria, nombre, Descripcion);
            categoria.Descripcion = "El casi mejor balsamo del mundo";
            resultadoObtenido = categoria.Descripcion;

            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }
        #endregion obtener parametros de instancias de  Categoria

    }
}